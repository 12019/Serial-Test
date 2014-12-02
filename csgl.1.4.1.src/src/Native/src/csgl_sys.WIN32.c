/*
 * BSD Licence:
 * Copyright (c) 2001, Lloyd Dupont (lloyd@galador.net)
 * <ORGANIZATION> 
 * All rights reserved.
 * 
 *
 * Redistribution and use in source and binary forms, with or without 
 * modification, are permitted provided that the following conditions are met:
 *
 * 1. Redistributions of source code must retain the above copyright notice, 
 * this list of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright 
 * notice, this list of conditions and the following disclaimer in the 
 * documentation and/or other materials provided with the distribution.
 * 3. Neither the name of the <ORGANIZATION> nor the names of its contributors
 * may be used to endorse or promote products derived from this software
 * without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE REGENTS OR CONTRIBUTORS BE LIABLE FOR
 * ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 
 * LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
 * OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH
 * DAMAGE.
 */
#include "csgl_sys.h"
#include <stdarg.h>
#include <windows.h>

int32_t csgl_sys_csgl_version() { return 2; }

int8_t csgl_sys_check_lib(char* name)
{
	HMODULE lib = LoadLibrary(name);
	if(lib)
		FreeLibrary(lib);
	
	return ((void *) lib) != (void *) 0;
}

int32_t csgl_sys_getLastError()
{
	return GetLastError();
}
void csgl_sys_setLastError(int32_t id)
{
	SetLastError(id);
}
char* csgl_sys_getErrorString(int32_t err, int32_t length, char* buf)
{
    FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM,
        NULL,
        err,
        MAKELANGID(LANG_NEUTRAL, SUBLANG_DEFAULT),
        buf,
        length,
        NULL);
	return buf;
}

// services for C function
static csCALLBACK fctASSERT = NULL;
static csCALLBACK fctASSERT_THROW = NULL;

void csgl_sys_initAssert(csCALLBACK assertFct, csCALLBACK assertThrowFct)
{
    fctASSERT = assertFct;
    fctASSERT_THROW = assertThrowFct;
}
void csgl_assert() 
{
    if(fctASSERT != NULL)
    	fctASSERT();
    else
    	DPRINT(assert failed due to exception unitialized -> call CsGL.OSLib.CSGLInit());
}
void csgl_assert_throw(char* msg)
{
    if(fctASSERT_THROW != NULL)
    	fctASSERT_THROW(msg);
   	DPRINT(assert failed due to exception unitialized -> call CsGL.OSLib.CSGLInit());
}
void csgl_assert_throw_format(char* format, ...)
{
    char buf[4096]; // hope it's enough ?
    va_list list;
    
    va_start(list, format);
    vsprintf(buf, format, list);
	va_end(list);
    
    csgl_assert_throw(buf);
}


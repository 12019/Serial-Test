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
#ifndef csgl_sys
#define csgl_sys
#include "csgl_definition.h"

DLLOBJ int32_t csgl_sys_csgl_version();

// init C-.NET assert/throw, called by OSLib at class init time
DLLOBJ void csgl_sys_initAssert(csCALLBACK assertFct, csCALLBACK assertThrowFct);

// services for throwing (.NET) error from other C function
// usefull for any interop C-function
DLLOBJ void csgl_assert(); // throw a NativeException if a system exception is found
DLLOBJ void csgl_assert_throw(char* msg); // call assert and throw a NativeException(msg)
DLLOBJ void csgl_assert_throw_format(char* format, ...); // as above & printf (max 4096 chars)

// error info gathering function
DLLOBJ int32_t csgl_sys_getLastError();
DLLOBJ void    csgl_sys_setLastError(int32_t id);
DLLOBJ char*   csgl_sys_getErrorString(int32_t eid, int32_t len, char* buf);

// check the availability of a library
DLLOBJ int8_t csgl_sys_check_lib(char* name);

#endif // csgl_sys

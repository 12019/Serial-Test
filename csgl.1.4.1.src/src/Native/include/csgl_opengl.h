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
#ifndef csgl_opengl
#define csgl_opengl
#include "csgl_definition.h"

// these define are the same as CsGL.OpenGL.DisplayFlags
// & also the same as the PFD_XXX version in <wingdi.h> on windows ...
#define CSGL_DOUBLEBUFFER    0x0001
#define CSGL_STEREO          0x0002
#define CSGL_DRAW_TO_WINDOW  0x0004
#define CSGL_DRAW_TO_BITMAP  0x0008
#define CSGL_SUPPORT_GDI     0x0010

// this structure is also used by C# code 
// as CsGL.OpenGL.DisplayType
typedef struct _csglDisplayType
{
	uint32_t flags;
    uint32_t isRgba;
    uint8_t  cColorBits; 
    uint8_t  cRedBits; 
    uint8_t  cGreenBits; 
    uint8_t  cBlueBits; 
    uint8_t  cAlphaBits; 
    uint8_t  cAccumBits; 
    uint8_t  cAccumRedBits; 
    uint8_t  cAccumGreenBits; 
    uint8_t  cAccumBlueBits; 
    uint8_t  cAccumAlphaBits; 
    uint8_t  cDepthBits; 
    uint8_t  cStencilBits; 
}
CsglPixel;

// get GL extension function
typedef void (APIENTRY* GL_FUNCTION)();
DLLOBJ GL_FUNCTION csgl_opengl_getProc(char* name);

// device specific
DLLOBJ void* csgl_opengl_getWndGDI(void* hwnd);
DLLOBJ void  csgl_opengl_letWndGDI(void* hwnd, void* gdi);

// manipulate GL context
DLLOBJ void* csgl_opengl_getCurrentCtxt();
DLLOBJ void  csgl_opengl_deleteCtxt(void* glCtxt);
DLLOBJ void  csgl_opengl_dropCtxt  (void* glCtxt);
DLLOBJ void* csgl_opengl_createCtxt(void* gdi, void* shareCtxt);
DLLOBJ void  csgl_opengl_grabCtxt  (void* gdi, void* glCtxt);
DLLOBJ void  csgl_opengl_swapBuffer(void* gdi, void* glCtxt);

// manipulate pixel format
DLLOBJ int32_t csgl_opengl_getNumFormat(void* gdi);
DLLOBJ void    csgl_opengl_setPixelFormat(void* gdi, int32_t index);
DLLOBJ void    csgl_opengl_setPixelFormatD(void* gdi, CsglPixel *fmt);
DLLOBJ int32_t csgl_opengl_getPixelFormat(void* gdi);
DLLOBJ void    csgl_opengl_getDisplayFromFormat(void* gdi, int32_t index, CsglPixel *ret);

#endif // csgl_opengl

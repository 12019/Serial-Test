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
#include "csgl_opengl.h"
#include "csgl_sys.h"
#include <windows.h>

GL_FUNCTION csgl_opengl_getProc(char* name)
{
	return (GL_FUNCTION) wglGetProcAddress(name);
}

// --------- device specific
void* csgl_opengl_getWndGDI(void* hwnd)
{
    HWND h = (HWND) hwnd;
    HDC hdc;
    if(h == NULL)
    	csgl_assert_throw("Windows Handle NULL");
        
    hdc = GetDC(h);
    if(hdc == NULL)
    	csgl_assert_throw("Windows GDI (Graphic Device Interface) NULL");
        
    return hdc;
}
void csgl_opengl_letWndGDI(void* hwnd, void* gdi)
{
	ReleaseDC((HWND) hwnd, (HDC) gdi);
}

// ----------- manipulate GL context
void* csgl_opengl_getCurrentCtxt()
{
	return wglGetCurrentContext();
}
void* csgl_opengl_createCtxt(void* gdi, void* shareCtxt)
{
    HGLRC hglrc = wglCreateContext((HDC) gdi);
    if(!hglrc)
    	csgl_assert_throw("Can't create GL context on device");
    if(shareCtxt && !wglShareLists(shareCtxt, hglrc)) {
    	wglDeleteContext(hglrc);
    	csgl_assert_throw("can't share list with this context");
    }
    return hglrc;
}
void csgl_opengl_deleteCtxt(void* glCtxt)
{
    if(glCtxt==NULL)
    	return;
	if(!wglDeleteContext((HGLRC) glCtxt))
    	csgl_assert_throw("Can't free GL context");
}
void csgl_opengl_grabCtxt(void* gdi, void* glCtxt)
{
    if(glCtxt == wglGetCurrentContext())
    	return;

    if(glCtxt == NULL)
    	csgl_assert_throw("NULL GL context");
    if(gdi == NULL)
    	csgl_assert_throw("NULL GDI");
        
	if(!wglMakeCurrent((HDC) gdi, (HGLRC) glCtxt))
		csgl_assert_throw("Can't make the context current");
}
void csgl_opengl_dropCtxt(void* glCtxt)
{
    if(glCtxt != wglGetCurrentContext())
    	return;
        
	if(!wglMakeCurrent(NULL, NULL))
		csgl_assert_throw("Can't set context to none");
}
void csgl_opengl_swapBuffer(void* gdi, void* glCtxt)
{
    if(gdi == NULL)
    	csgl_assert_throw("NULL GDI");
	if(!SwapBuffers((HDC) gdi))
		csgl_assert();
}

// --------- manipulate pixel format
int32_t csgl_opengl_getNumFormat(void* gdi)
{
	int32_t num = (int32_t) DescribePixelFormat((HDC) gdi, 1, 0, NULL);
	if(!num)
		csgl_assert();
	return num;
}
void csgl_opengl_setPixelFormat(void* gdi, int32_t index)
{
	if(!SetPixelFormat((HDC) gdi, index+1, NULL))
    	csgl_assert_throw("Can't set PixelFormat");
}
void csgl_opengl_setPixelFormatD(void* gdi, CsglPixel *fmt)
{
	int format;
	PIXELFORMATDESCRIPTOR pix;
	memset(&pix, 0, sizeof(PIXELFORMATDESCRIPTOR));
	pix.nSize = sizeof(PIXELFORMATDESCRIPTOR);
	pix.nVersion = 1;
	
	pix.dwFlags  = fmt->flags;
	pix.dwFlags |= PFD_SUPPORT_OPENGL; 
	pix.dwFlags |= fmt->isRgba ? 0 : PFD_NEED_PALETTE;
	pix.iPixelType = fmt->isRgba ? PFD_TYPE_RGBA : PFD_TYPE_COLORINDEX;
	
	pix.cColorBits      = fmt->cColorBits;
	pix.cRedBits        = fmt->cRedBits;
	pix.cGreenBits      = fmt->cGreenBits;
	pix.cBlueBits       = fmt->cBlueBits;
	pix.cAlphaBits      = fmt->cAlphaBits;
	pix.cAccumBits      = fmt->cAccumBits;
	pix.cAccumRedBits   = fmt->cAccumRedBits;
	pix.cAccumGreenBits = fmt->cAccumGreenBits;
	pix.cAccumBlueBits  = fmt->cAccumBlueBits;
	pix.cAccumAlphaBits = fmt->cAccumAlphaBits;
	pix.cDepthBits      = fmt->cDepthBits;
	pix.cStencilBits    = fmt->cStencilBits;
	
	format = ChoosePixelFormat((HDC) gdi, &pix);
	if(!format)
		csgl_assert_throw("unable to find proper format");
	if(!SetPixelFormat((HDC) gdi, format, &pix))
		csgl_assert_throw("can't set PixelFormat");
}
int32_t csgl_opengl_getPixelFormat(void* gdi)
{
    if(gdi == NULL)
    	csgl_assert_throw("NULL GDI");
    return GetPixelFormat((HDC) gdi)-1;
}
void csgl_opengl_getDisplayFromFormat(void* gdi, int32_t index, CsglPixel *ret)
{
	PIXELFORMATDESCRIPTOR pix;
	memset(&pix, 0, sizeof(PIXELFORMATDESCRIPTOR));
	pix.nSize = sizeof(PIXELFORMATDESCRIPTOR);
	pix.nVersion = 1;
	
    if(ret == NULL)
    	return;
    if(gdi == NULL)
    	csgl_assert_throw("NULL GDI");
	if(!DescribePixelFormat((HDC) gdi, index+1, pix.nSize, &pix))
    	csgl_assert_throw("Access pixel format description failed.");
		
	ret->flags           = (uint32_t) pix.dwFlags;
	ret->isRgba          = pix.iPixelType == PFD_TYPE_RGBA;
	ret->cColorBits      = pix.cColorBits;
	ret->cRedBits        = pix.cRedBits;
	ret->cGreenBits      = pix.cGreenBits;
	ret->cBlueBits       = pix.cBlueBits;
	ret->cAlphaBits      = pix.cAlphaBits;
	ret->cAccumBits      = pix.cAccumBits;
	ret->cAccumRedBits   = pix.cAccumRedBits;
	ret->cAccumGreenBits = pix.cAccumGreenBits;
	ret->cAccumBlueBits  = pix.cAccumBlueBits;
	ret->cAccumAlphaBits = pix.cAccumAlphaBits;
	ret->cDepthBits      = pix.cDepthBits;
	ret->cStencilBits    = pix.cStencilBits;
}

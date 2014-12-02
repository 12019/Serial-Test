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
#ifndef csgl_mouse
#define csgl_mouse
#include "csgl_definition.h"

DLLOBJ void csgl_mouse_setPos(int32_t x, int32_t y);
DLLOBJ void csgl_mouse_getPos(int32_t* x, int32_t* y);

#define CSGL_MOUSE_DOWN  0
#define CSGL_MOUSE_UP    1
#define CSGL_MOUSE_MOVE  2
#define CSGL_MOUSE_WHEEL 3
typedef struct _MouseEvent
{
	int8_t  type;
	int32_t x,y;
	int32_t button;
	int32_t clicCount;
	int32_t wheel; 
	void* hwnd;
} 
MouseEvent;
typedef void (APIENTRY *MouseHook)(MouseEvent me);
DLLOBJ void csgl_mouse_hook(MouseHook fct);

// -- cursor stuff
DLLOBJ void  csgl_mouse_getCursorSize(int32_t* x, int32_t* y);
DLLOBJ void* csgl_mouse_createCursor(void* hBitmap, int32_t x, int32_t y);
DLLOBJ void  csgl_mouse_destroyCursor(void* hCursor);

#endif // csgl_mouse

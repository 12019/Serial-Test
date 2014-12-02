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
#include "csgl_mouse.h"
#include "csgl_sys.h"
#include <windows.h>
#include <memory.h>

void csgl_mouse_setPos(int32_t x, int32_t y)
{
	if(!SetCursorPos(x, y))
		csgl_assert_throw("can't set cursor position");
}
void csgl_mouse_getPos(int32_t* x, int32_t* y)
{
	POINT p;
	if(!GetCursorPos(&p))
		csgl_assert_throw("can't get cursor position");
	*x = (int32_t) p.x;
	*y = (int32_t) p.y;
}

static MouseHook mHook = NULL;
static HHOOK meWheel = NULL;
static HHOOK me = NULL;
LRESULT CALLBACK GetMsgProc(int code, WPARAM wParam, LPARAM lParam)
{
	LRESULT ret = CallNextHookEx(me, code, wParam, lParam);
	if(me && code==HC_ACTION && wParam==PM_REMOVE && mHook) {
		MSG* pMsg = (MSG*)lParam;
		MouseEvent me;
		switch(pMsg->message) {
			case WM_MOUSEWHEEL:
				memset(&me, 0, sizeof(MouseEvent));
				me.type   = CSGL_MOUSE_WHEEL;
				me.hwnd   = pMsg->hwnd;
				me.button = 3;
				me.wheel  = (int16_t) HIWORD(pMsg->wParam);
				me.x      = LOWORD(pMsg->lParam);
				me.y      = HIWORD(pMsg->lParam);
				mHook(me);
				break;
		}
	}
	return ret;
}
static LRESULT CALLBACK MouseProc(int code, WPARAM wParam, LPARAM lParam)
{
	LRESULT ret = CallNextHookEx(me, code, wParam, lParam);
	if(code==HC_ACTION && mHook) {
		MOUSEHOOKSTRUCT* mhs = (MOUSEHOOKSTRUCT*) lParam;
		MouseEvent me;
		memset(&me, 0, sizeof(MouseEvent));
		me.x     = mhs->pt.x;
		me.y     = mhs->pt.y;
		me.hwnd  = mhs->hwnd;
		switch(LOWORD(wParam)) {
			case WM_LBUTTONDOWN:
				me.type = CSGL_MOUSE_DOWN;
				me.button    = 1;
				me.clicCount = 1;
				break;
			case WM_LBUTTONUP:
				me.type = CSGL_MOUSE_UP;
				me.button    = 1;
				break;
			case WM_LBUTTONDBLCLK:
				me.type = CSGL_MOUSE_DOWN;
				me.button    = 1;
				me.clicCount = 2;
				break;
			case WM_RBUTTONDOWN:
				me.type = CSGL_MOUSE_DOWN;
				me.button    = 2;
				me.clicCount = 1;
				break;
			case WM_RBUTTONUP:
				me.type = CSGL_MOUSE_UP;
				me.button    = 2;
				break;
			case WM_RBUTTONDBLCLK:
				me.type = CSGL_MOUSE_DOWN;
				me.button    = 2;
				me.clicCount = 2;
				break;
			case WM_MBUTTONDOWN:
				me.type = CSGL_MOUSE_DOWN;
				me.button    = 3;
				me.clicCount = 1;
				break;
			case WM_MBUTTONUP:
				me.type = CSGL_MOUSE_UP;
				me.button    = 3;
				break;
			case WM_MBUTTONDBLCLK:
				me.type = CSGL_MOUSE_DOWN;
				me.button    = 3;
				me.clicCount = 2;
				break;
			case WM_MOUSEMOVE:
				me.type = CSGL_MOUSE_MOVE;
				break;
			default:
				goto end;
		}
		mHook(me);
	}
end:
	return ret;
}
__cdecl static void removeMe()
{
	UnhookWindowsHookEx(me);
	UnhookWindowsHookEx(meWheel);
}
void csgl_mouse_hook(MouseHook fct)
{
	if(mHook || !fct) // ??
		return; 
		
	me = SetWindowsHookEx(WH_MOUSE, &MouseProc, NULL, GetCurrentThreadId());
	meWheel = SetWindowsHookEx(WH_GETMESSAGE, GetMsgProc, NULL, GetCurrentThreadId());
	if(!me)
		csgl_assert_throw("can't set mouse hook");
	atexit(&removeMe);
	mHook = fct;
}

// --- cursor stuff --
void* csgl_mouse_createCursor(void* hBitmapVoid, int32_t x, int32_t y)
{
	int h, w;
	HBITMAP img, mask;
	BITMAP imgInf;
	HICON cursor;
	ICONINFO info;
	
	w = GetSystemMetrics(SM_CXCURSOR);
	h = GetSystemMetrics(SM_CYCURSOR);
	
	img = (HBITMAP) hBitmapVoid;
	if(!GetObject(img, sizeof(BITMAP), &imgInf))
		csgl_assert_throw("can't access image information");
		
	if(w<imgInf.bmWidth || h<imgInf.bmHeight) {
		csgl_sys_setLastError(NO_ERROR);
		csgl_assert_throw_format("image size incorrect, should be < %dx%d", w, h);
	}
	w = imgInf.bmWidth;
	h = imgInf.bmWidth;
	
	if(!( mask = CreateBitmap(w,h,1,1,NULL) ))
		csgl_assert_throw("unable to create mask");
		
	info.fIcon = FALSE; // cursor
	info.xHotspot = x;
	info.yHotspot = y;
	info.hbmColor = img;
	info.hbmMask  = mask;
	if(!( cursor = CreateIconIndirect(&info) )) {
		DeleteObject((HGDIOBJ) mask);
		csgl_assert_throw("unable to create cursor");
	}
	
	DeleteObject((HGDIOBJ) mask);
	return (void*) cursor;
}
void csgl_mouse_getCursorSize(int32_t* x, int32_t* y)
{
	*x = GetSystemMetrics(SM_CXCURSOR);
	*y = GetSystemMetrics(SM_CYCURSOR);
}
void csgl_mouse_destroyCursor(void* hCursor)
{
	DestroyIcon((HICON) hCursor);
}

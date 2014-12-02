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
#include "csgl_keyboard.h"
#include "csgl_sys.h"
#include <windows.h>

#define KINFO(x) printf("key " #x "(%x) = %x\n", x, GetKeyState(x));

int32_t csgl_kb_getKeyState(int32_t key)
{
	SHORT s = GetKeyState(key);
	return (s&0xFF00) != 0;
}
void csgl_kb_getKeyArrayState(int8_t* keys)
{
	if(!GetKeyboardState(keys))
		csgl_assert_throw("can't access keyboard state");
}

static KbHook kbFeedback = NULL;
static HHOOK me = NULL;
static LRESULT CALLBACK KeyboardProc(int code, WPARAM wParam, LPARAM lParam)
{
	// call first in case exception are thrown...
	LRESULT ret = CallNextHookEx(me, code, wParam, lParam);
	if(code==HC_ACTION&&kbFeedback) {
		HWND wnd = GetActiveWindow();
		KeyEvent ke;
		memset(&ke, 0, sizeof(KeyEvent));
		ke.hwnd = (void*) wnd;
		ke.key  = (int32_t) wParam;
		
		if((lParam&0x80000000)!=0) { // key up
			ke.state = CSGL_KEY_UP;
			kbFeedback(ke);
		}
		else if((lParam&0x40000000)!=0) { // key typed (repeated)
			ke.state = CSGL_KEY_TYPED;
			kbFeedback(ke);
		}
		else /*if((lParam&0xC0000000)==0)*/ { // key down...
			ke.state = CSGL_KEY_DOWN;
			kbFeedback(ke);
			
			ke.state = CSGL_KEY_TYPED;
			kbFeedback(ke);
		}
	}
	return ret;
}
__cdecl static void removeMe()
{
	UnhookWindowsHookEx(me);
}
void csgl_kb_setHook(KbHook fct)
{
	if(kbFeedback || !fct) // ??
		return;
	
	me = SetWindowsHookEx(WH_KEYBOARD, &KeyboardProc, NULL, GetCurrentThreadId());
	if(!me)
		csgl_assert_throw("can't set keyboard hook");
	atexit(&removeMe);
	kbFeedback = fct;
}

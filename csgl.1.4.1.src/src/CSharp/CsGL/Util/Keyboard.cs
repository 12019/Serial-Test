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
using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CsGL.Util
{
	/**
	 * This class gather information about keyboard state. unlike 
	 * OnKeySomething method they are accurate and could be accessed
	 * from anywhere in the application (not only from a Control).
	 * <p/>
	 * the bool[] array returned by some function contain the state
	 * (pressed or not of the key) you use it like this:<br>
	 * &nbsp; <tt>bool isPScreen = Keyboard.GetKeysState()[(int)Keys.Snapshot]</tt>, or<br/>
	 * &nbsp; <tt>bool isPScreen = Keyboard.IsKeyPressed(Keys.Snapshot)</tt>
	 * <p/>
	 * The static methods IsKeyPressed & GetKeysState could safely
	 * be assumed to be portable. I am not sure of the same for
	 * instance and AddListener methods. but they require less 
	 * calculation than GetKeysState(). Beside some key are 
	 * incorrectly reported in Keyboard instances and in the hook
	 * 
	 * @see Hook
	 */
	public class Keyboard : CsGL.OSLib
	{
		/**
		 * return wether or not a given key is pressed
		 */
		[DllImport(CSGL, EntryPoint="csgl_kb_getKeyState", CallingConvention=CallingConvention.Cdecl)]
		public static extern bool IsKeyPressed(Keys k);
		
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
		private unsafe static extern void csgl_kb_getKeyArrayState(byte* kbArray);
		
		
		/**
		 * take an array of bool[256]. fill it with a boolean
		 * stating if the given virtual key is pressed or not.<br>
		 * to know if a given key is pressed just do that:<br/>
		 */
		public unsafe static void GetKeysState(bool[] state)
		{
			byte* ret = stackalloc byte[256];
			csgl_kb_getKeyArrayState(ret);
			for(int i=0; i<256; i++)
				state[i] = (ret[i]&0xF0) != 0;
		}
		
		/** return an array of bool wich is true if the given 
		 * key is pressed.
		 */
		public static bool[] GetKeysState()
		{
			bool[] ret = new bool[256];
			GetKeysState(ret);
			return ret;
		}
		
		// -------- HOOK & listeners --------
		public enum KeyState : byte
		{
			/** nearly each key down generate 1 */
			DOWN  = 0,
			/** each key up generate 1 */
			UP = 1,
			/** nearly each key down generate 1 or more (could be repeated) */
			TYPED = 2
		}
	    [StructLayout(LayoutKind.Sequential)]
		public struct Event
		{
			/** the type of event */
			public KeyState state;
			/** the key of the event */
			public Keys key; 
			/** the currently foused window handle */
			private IntPtr hwnd;
			
			/** the control owning the focus */
			public Control Control
			{
				get { 
					if(hwnd==IntPtr.Zero)
						return null;
					return Control.FromHandle(hwnd);
				}
			}
			public override string ToString()
			{
				StringBuilder sb = new StringBuilder();
				sb.Append("Key+Event(");
				sb.Append(state);
				sb.Append(' ');
				sb.Append(key);
				Control c = Control;
				if(c!=null) {
					sb.Append(' ');
					sb.Append('@');
					sb.Append(Control);
				}
				sb.Append(')');
				return sb.ToString();
			}
		}
		/** call this callback function anytime a key event occur.
		 * some key doesn't work very well, like PrintScreen which
		 * is called only on KeyUp.... but IsKeyPressed give accurate
		 * values */
		public delegate void Hook(Event e);
		
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
		private static extern void csgl_kb_setHook(Hook fct);

		static ArrayList hooks;
		public static void AddListener(Hook fct)
		{
			if(hooks==null) {
				CSGLInit();
				hooks = new ArrayList();
				kbHook = new Hook(SysHook);
				csgl_kb_setHook(kbHook);
			}
			hooks.Add(fct);
		}
		public static void RemoveListener(Hook fct) 
		{
			if(hooks!=null)
				hooks.Remove(fct);
		}
		private static Hook kbHook;
		private static void SysHook(Event e)
		{
			foreach(Hook h in hooks)
				try { h(e); }
				catch(Exception ex) {
					Console.Error.WriteLine(ex);
					Console.Error.WriteLine(ex.StackTrace);
				}
		}
		
		// ---------- INSTANCE methods ----------
		private void spyKey(Event e) 
		{ 
			State[(int)e.key] = e.state != KeyState.UP;
			KeyStateChanged(e);
		}
		
		/** override this method to do something after a key event.
		 * could be a right place to test KeyUp on PrintScreen key... */
		public virtual void KeyStateChanged(Event e) {}
		
		public Keyboard()
		{
			AddListener(new Hook(spyKey));
		}
		~Keyboard() { RemoveListener(new Hook(spyKey)); }
		
		/** usefull if your application lost focus. call it every 
		 * time after a gain focus..  */
		public void Reset() { state = null; }
		private bool[] state;
		public bool[] State { 
			get { 
				if(state==null)
					state = GetKeysState();
				return state; 
			}
		}
	}
}

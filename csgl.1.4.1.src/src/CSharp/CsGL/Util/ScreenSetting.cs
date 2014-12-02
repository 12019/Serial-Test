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
using System.Threading;
using System.Runtime.InteropServices;

namespace CsGL.Util
{
	public struct ScreenSetting
	{
		/** the number of horizontal pixel for this mode */
		public int Width;
		
		/** the number of vertical pixel for this mode */
		public int Height;
		
		/** the number of color bit for this mode */
		public int CDepth;
		
		public ScreenSetting(int w, int h)
		{
			ScreenSetting ss = CurrentDisplay;
			Width = w;
			Height = h;
			CDepth = ss.CDepth;
		}
		public ScreenSetting(int w, int h, int depth)
		{
			Width = w;
			Height = h;
			CDepth = depth;
		}
		
		// verify the mode is available
		public bool Valid
		{
			get {
				int n = CountDisplay;
				for(int i=0; i<n; i++) {
					ScreenSetting ss = GetDisplay(i);
					if(ss.Equals(this))
						return true;
				}
				return false;
			}
		}
		
		public bool Equals(ScreenSetting ss)
		{
			return Width == ss.Width 
				&& Height == ss.Height 
				&& CDepth == ss.CDepth;
		}
		public override string ToString()
		{
			return Width+"x"+Height+" x"+CDepth+"bpp";
		}
		
		[DllImport(CsGL.OSLib.CSGL, CallingConvention=CallingConvention.Cdecl)]
		static extern void csgl_screen_setDisplay(int w, int h, int bpp);
		
		/** set this setting as the current display */
		public void Set()
		{
			csgl_screen_setDisplay(Width, Height, CDepth);
		}
		
		/** revert the original display setting */
		public static void Reset()
		{
			csgl_screen_setDisplay(0, 0, 0);
		}
		
		[DllImport(CsGL.OSLib.CSGL, CallingConvention=CallingConvention.Cdecl)]
		static extern int csgl_screen_countDisplay();
		
		public static int CountDisplay
		{
			get { return csgl_screen_countDisplay(); }
		}
		
		[DllImport(CsGL.OSLib.CSGL, CallingConvention=CallingConvention.Cdecl)]
		static extern void csgl_screen_getDisplay(int index, out int w, out int h, out int c);
		
		public static ScreenSetting GetDisplay(int index)
		{
			ScreenSetting ss = new ScreenSetting();
			csgl_screen_getDisplay(index, out ss.Width, out ss.Height, out ss.CDepth);
			return ss;
		}
		
		/// <summary> return current display </summary>
		public static ScreenSetting CurrentDisplay
		{
			get { return GetDisplay(-1); }
		}
		
		[DllImport(CsGL.OSLib.CSGL, CallingConvention=CallingConvention.Cdecl)]
		static extern int csgl_screen_isCompatibleDisplay(int index);
		
		/**
		 * return if the given display has the same bpp, frequency, 
		 * and other hidden stuff... than the current display
		 */
		public static bool IsCompatibleDisplay(int i)
		{
			return csgl_screen_isCompatibleDisplay(i) != 0;
		}
		
		public static ScreenSetting[] CompatibleDisplay
		{
			get {
				int i,n=CountDisplay;
				ArrayList al = new ArrayList();
				for(i=0; i<n; i++)
					if(IsCompatibleDisplay(i))
						al.Add(GetDisplay(i));
				n = al.Count;
				ScreenSetting[] ret = new ScreenSetting[n];
				for(i=0; i<n; i++)
					ret[i] = (ScreenSetting) al[i];
				return ret;
			}
		}
	}
}

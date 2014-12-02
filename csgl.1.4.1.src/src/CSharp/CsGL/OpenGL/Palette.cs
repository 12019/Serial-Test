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
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;

namespace CsGL.OpenGL
{
	/**
	 * this Object is automatically created by the context in case
	 * of indexed color mode.
	 * <p>
	 * <B>ANYWAY IT DOESN'T WORK YET</B>
	 * <br>
	 * If anyone has idea, I given up. BTW they should be automatically
	 * created and accessed from Palette "aware" OpenGLContext
	 */
 	public class Palette : CsGL.OSLib, IDisposable
 	{
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
		internal static extern IntPtr csgl_palette_createPalette(ref DisplayType fmt, IntPtr hdc, out int size);
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
		internal static extern void csgl_palette_destroyPalette(IntPtr pal, IntPtr hdc);
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
		internal static extern void csgl_palette_color(IntPtr pal, bool isGet, int index, ref byte r, ref byte g, ref byte b);
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
		internal static extern void csgl_palette_update(IntPtr pal, IntPtr hdc);
 		
 		[Serializable]
		public struct Color
 		{
 			public byte r,g,b;
 			public Color(byte red, byte green, byte blue)
 			{
 				r = red;
 				g = green;
 				b = blue;
 			}
 		}
 		
 		int size;
 		IntPtr handle;
 		OpenGLContext context;
 		
 		public Palette(IntPtr aHandle, int aSize, OpenGLContext ctxt)
 		{
 			size = aSize;
 			context = ctxt;
 		}
 		~Palette() { Dispose(); }
 		
 		public virtual int Size { get { return size; } }
 		
 		public virtual void Dispose()
 		{
 			if(handle==IntPtr.Zero)
 				return;
 			IntPtr p = context.Valid ? context.GetNativeGDI() : IntPtr.Zero;
			csgl_palette_destroyPalette(handle, p);
 			if(p != IntPtr.Zero)
				context.ReleaseNativeGDI(p);
 			handle = IntPtr.Zero;
			GC.SuppressFinalize(this);
 		}
 		
 		public virtual Color this[int index]
 		{
 			get {
 				if(index<0||index>=size)
 					throw new IndexOutOfRangeException();
 				Color ret = new Color();
 				csgl_palette_color(handle, true, index, ref ret.r
 				                   	                  , ref ret.g
 				                   	                  , ref ret.b);
 				return ret;
 			}
 			set {
 				if(index<0||index>=size)
 					throw new IndexOutOfRangeException();
 				csgl_palette_color(handle, false, index, ref value.r
 				                   	                   , ref value.g
 				                   	                   , ref value.b);
 			}
 		}
 		
 		/** get an array with the current color values
 		 * of the palette */
 		public virtual Color[] Colors
 		{
 			get {
 				Color[] ret = new Color[Size];
 				for(int i=0; i<ret.Length; i++)
 					ret[i] = this[i];
 				return ret;
 			}
 		}
 		
 		/** update the palette with whatever you have set */
 		public virtual void Sync()
 		{
 			IntPtr p = context.GetNativeGDI();
			try { csgl_palette_update(handle, p); }
			finally { context.ReleaseNativeGDI(p); }
 		}
 	}
}

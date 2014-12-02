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
using System.Windows.Forms;

namespace CsGL.OpenGL
{
	/** a concrete subclass of OpenGLContext for Control.
	 * You should call Create yourself to activate this context
	 * */
	public class ControlGLContext : OpenGLContext
	{
		protected readonly Control control;
		public ControlGLContext(Control c)
		{
			control = c;
		}
		
		public override void Dispose()
		{
			base.Dispose();
		}
		public override IntPtr GetNativeGDI()
		{
			return GetNativeGDI(control.Handle);
		}
		public override void ReleaseNativeGDI(IntPtr p)
		{
			ReleaseNativeGDI(control.Handle, p);
		}
		
		[DllImport(CSGL, EntryPoint="csgl_opengl_getWndGDI", CallingConvention=CallingConvention.Cdecl)]
		private static extern IntPtr GetNativeGDI(IntPtr hwnd);
		[DllImport(CSGL, EntryPoint="csgl_opengl_letWndGDI", CallingConvention=CallingConvention.Cdecl)]
		private static extern void ReleaseNativeGDI(IntPtr hwnd, IntPtr p);
	}
}

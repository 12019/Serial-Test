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
using CsGL.Util;
using System.Runtime.InteropServices;

namespace CsGL
{
	[System.Serializable]
	public abstract class OSLib
	{
		private delegate void ASSERT();
		private delegate void ASSERT_THROW([MarshalAs(UnmanagedType.LPStr)]string s);
		private static readonly ASSERT assert;
		private static readonly ASSERT_THROW assertT;
		
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
		private static extern void csgl_sys_initAssert(ASSERT a, ASSERT_THROW at);
		
		// check library first
		static OSLib() 
		{
			// init C-exception
			assert = new ASSERT(CsGL.Util.NativeException.Assert);
			assertT = new ASSERT_THROW(CsGL.Util.NativeException.AssertThrow);
			csgl_sys_initAssert(assert, assertT);
			
			// check opengl..
			string pb = null;
			
			if(! CheckLibrary(OPENGL_LIB))
				pb = "OpenGL not found on your system.";
			if(! CheckLibrary(GLU_LIB)) {
				if(pb != null)
					pb += "\n";
				pb += "GLU not found on your system.";
				
			}
			if(CSGLNativeVersion()<2) {
				if(pb != null)
					pb += "\n";
				pb += "csgl.native.dll is an incorrect version (too old)";
			}
			
			if(pb != null)
				System.Windows.Forms.MessageBox.Show(pb, "Problems");
		}
		
		/** do nothing. but you could call it, so OSLib() will be called
		 * if it was not already done */
		public static void CSGLInit() {}
		
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
		static extern byte csgl_sys_check_lib(string name);
		public static bool CheckLibrary(string name)
		{
			return csgl_sys_check_lib(name) != 0;
		}
		
		[DllImport(CSGL, EntryPoint="csgl_sys_csgl_version", CallingConvention=CallingConvention.Cdecl)]
		public static extern int CSGLNativeVersion();
		
#if WIN32
		public const string OPENGL_LIB = "OPENGL32.DLL";
		public const string GLU_LIB    = "GLU32.DLL";
		public const string CSGL       = "csgl.native.dll";
#endif 
	}
}

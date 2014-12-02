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
using System.Runtime.InteropServices;
using CsGL.OpenGL;
using CsGL.Util;

namespace CsGL.OpenGL
{
	/// <summary>
	/// This is an helper class to query the system about 
	/// presence of extension
	/// </summary>
	public abstract class XInfo : GL
	{
		// extension list
		static ContextLocal all_ext = new ContextLocal();
		
		/// <summary>
		/// return the list of extension available in the current
		/// OpenGLContext
		/// </summary>
		public static string[] Extensions
		{
			get
			{
				string[] ext = (string[]) all_ext.Value;
				if(ext == null) {
					OpenGLContext c = OpenGLContext.Current;
					if(c == null || !c.Valid)
						return null;
					
					ext = glGetString(GL_EXTENSIONS).Split(new char[]{' '});
					all_ext.Value = ext;
				}
				return ext;
			}
		}
		
		/// <summary>
		/// check if a particular extension is available in the
		/// current OpenGLContext
		/// </summary>
		public static bool IsPresent(string ext)
		{
			if(OpenGLContext.Current == null)
				return false;
			
			string[] s = Extensions;
			for(int i=0; i<s.Length; i++)
				if(s[i] == ext)
					return true;
			return false;
		}
		
		/** if you are unsure of the extension you could simply test 
		 * the implementation of the function named 'function' */
		public static bool IsImplemented(string function)
		{
			return GetProc(function) != IntPtr.Zero;
		}
	}
}

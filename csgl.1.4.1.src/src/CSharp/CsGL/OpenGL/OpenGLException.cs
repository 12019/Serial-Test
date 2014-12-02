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
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace CsGL.OpenGL
{
	/// <summary>
	/// standart error for 3D exception which, though rare, could
	/// occur, generaly in some init process.
	/// the definitive way to use it is through its 'Assert()' method
	/// </summary>
	[Serializable]
	public class OpenGLException : NativeException
	{
		public OpenGLException(uint id) : base((int)id, GL.gluErrorString(id))
		{
		}
		public OpenGLException(string msg) : base((int)GL.GL_NO_ERROR, msg)
		{
		}
		
		public override string ToString()
		{
			return GetType().Name+'('+ID+"): "+Message;
		}
		
		/// <summary>
		/// test an error in OpenGL engine and throw an OpenGLException 
		/// with a comprehensive string error message if one is found.
		/// Though it mask its parent method (NativeException.Assert())
		/// it doesn't check its parent's method
		/// </summary> 
		public new static void Assert() 
		{
			if(OpenGLContext.Current == null)
				return;
			
			// test OpenGL engine ...
			uint err = GL.glGetError();
			if(err != GL.GL_NO_ERROR)
				throw new OpenGLException(err);
		}
		
		public static void Check() { Check("error"); }
		/** test if there is a GL error. and just print it in the error 
		 * stream if one is found. */
		public static void Check(string msg)
		{
			if(OpenGLContext.Current == null)
				return;
			
			// test OpenGL engine ...
			uint err = GL.glGetError();
			if(err != GL.GL_NO_ERROR) {
				string s = GL.gluErrorString(err);
				Console.WriteLine(msg + " - "+err+" - "+s);
			}
		}
	}
}

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
using System.Text;
using System.Runtime.InteropServices;

namespace CsGL.Util
{
	/**
	* this class manage OS specific error
	*/
	public class NativeException : SystemException
	{
		private int id;
		public const int NO_ERROR = 0;
		
		public NativeException(int anId, string cause) : base(cause)
		{
			id = anId;
		}
		public NativeException(int anId) : base(GetErrorString(anId))
		{
			id = anId;
		}
		public NativeException(string cause) : base(cause)
		{
			id = NO_ERROR;
		}
		
		public int ID { get { return id; } }
		
		// check an error and throw it
		public static void Assert()
		{
			int anId = SysError;
			if(anId == NO_ERROR)
				return;
			SysError = NO_ERROR;
			throw new NativeException(anId);
		}
		/**
		* check an error and if not found throw a NativeException
		* with the given message
		*/
		public static void AssertThrow(string msg)
		{
			Assert();
			throw new NativeException(msg);
		}
		
		public override string ToString()
		{
			return GetType().Name+'('+ID+")\t"+Message;
		}
		
		[DllImport(CsGL.OSLib.CSGL, CallingConvention=CallingConvention.Cdecl)]
		static extern int csgl_sys_getLastError();
		[DllImport(CsGL.OSLib.CSGL, CallingConvention=CallingConvention.Cdecl)]
		static extern void csgl_sys_setLastError(int id);
		[DllImport(CsGL.OSLib.CSGL, CallingConvention=CallingConvention.Cdecl)]
		static extern string csgl_sys_getErrorString(int eid, int l, StringBuilder str);

		// helpers members 
		public static int SysError
		{
			get { return csgl_sys_getLastError(); }
			set { csgl_sys_setLastError(value); }
		}
		public static string GetErrorString(int anId)
		{
			StringBuilder sb = new StringBuilder(4096);
			return csgl_sys_getErrorString(anId, 4096, sb);
		}
	}
}

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

namespace CsGL.Pointers
{
	/**
	 * Simple struct int32 layout (int, 4 bytes).
	 */
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct RInt32
	{
		/**
		 * Int pointer.
		 */
		int* data;
		
		/**
		 * Constructor/Initializer from IntPtr p.
		 * @param p Creates the int pointer from p.
		 */
		public RInt32(IntPtr p) { data = (int*)(void*) p; }

		/**
		 * Array accessor.
		 * @param index Index of the int to get.
		 */
		public int this[int index]
		{
			get { return data[index]; }
			set { data[index] = value; }
		}
		
		public static explicit operator IntPtr(RInt32 p) { return (IntPtr) p.data; }
		public static explicit operator RInt32(IntPtr p) { return new RInt32(p); }
		public static RInt32 operator+(RInt32 p, int index)
		{
			RInt32 ret;
			ret.data = p.data + index;
			return ret;
		}
		public static RInt32 operator-(RInt32 p, int index)
		{
			RInt32 ret;
			ret.data = p.data - index;
			return ret;
		}
		public static int operator-(RInt32 a, RInt32 b) { return (int) (a.data - b.data); }
	}
}

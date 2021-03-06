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
	 * Simple struct layout for uint16 (ushort, 2 bytes).
	 */
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct RUInt16
	{
		/**
		 * ushort pointer.
		 */
		ushort* data;
		
		/**
		 * Constructor/Initializer with IntPtr p.
		 * @param p Creates ushort pointer.
		 */
		public RUInt16(IntPtr p) { data = (ushort*)(void*) p; }

		/**
		 * Array accessor.
		 * @param index Index to the ushort to get/set.
		 */
		public ushort this[int index]
		{
			get { return data[index]; }
			set { data[index] = value; }
		}
		
		public static explicit operator IntPtr(RUInt16 p) { return (IntPtr) p.data; }
		public static explicit operator RUInt16(IntPtr p) { return new RUInt16(p); }
		public static RUInt16 operator+(RUInt16 p, int index)
		{
			RUInt16 ret;
			ret.data = p.data + index;
			return ret;
		}
		public static RUInt16 operator-(RUInt16 p, int index)
		{
			RUInt16 ret;
			ret.data = p.data - index;
			return ret;
		}
		public static int operator-(RUInt16 a, RUInt16 b) { return (int) (a.data - b.data); }
	}
}

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
	 * Simple pointer layout struct for float.
	 */
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct RFloat
	{
		/**
		 * Float pointer.
		 */
		float* data;
		
		/**
		 * Constructor/Initializer, creates struct from p.
		 * @param p IntPtr struct is to hold.
		 */
		public RFloat(IntPtr p) { data = (float*)(void*) p; }

		/**
		 * Array accessor.
		 * @param index Index of float to access.
		 */
		public float this[int index]
		{
			get { return data[index]; }
			set { data[index] = value; }
		}
		
		public static explicit operator IntPtr(RFloat p) { return (IntPtr) p.data; }
		public static explicit operator RFloat(IntPtr p) { return new RFloat(p); }
		public static RFloat operator+(RFloat p, int index)
		{
			RFloat ret;
			ret.data = p.data + index;
			return ret;
		}
		public static RFloat operator-(RFloat p, int index)
		{
			RFloat ret;
			ret.data = p.data - index;
			return ret;
		}
		public static int operator-(RFloat a, RFloat b) { return (int) (a.data - b.data); }
	}
}

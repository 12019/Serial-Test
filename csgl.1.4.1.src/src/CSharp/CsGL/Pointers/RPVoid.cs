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
	 * Pointer to pointer struct [?].
	 */
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct RPVoid
	{
		/**
		 * Data pointer pointer void.
		 */
		void** data;
		
		/**
		 * Constructor/Initializer, creates a pointer pointer void from an IntPtr (see Pointer header file).
		 * @param p IntPtr structure to get data from.
		 */
		public RPVoid(IntPtr p) { data = (void**)(void*) p; }

		/**
		 * Array like accessor for pointer pointer array.
		 */
		public IntPtr this[int index]
		{
			get { return (IntPtr) data[index]; }
			set { data[index] = (void**)(void*)value; }
		}
		
		public static explicit operator IntPtr(RPVoid p) { return (IntPtr) p.data; }
		public static explicit operator RPVoid(IntPtr p) { return new RPVoid(p); }
		public static RPVoid operator+(RPVoid p, int index)
		{
			RPVoid ret;
			ret.data = p.data + index;
			return ret;
		}
		public static RPVoid operator-(RPVoid p, int index)
		{
			RPVoid ret;
			ret.data = p.data - index;
			return ret;
		}
		public static int operator-(RPVoid a, RPVoid b) { return (int) (a.data - b.data); }
	}
}

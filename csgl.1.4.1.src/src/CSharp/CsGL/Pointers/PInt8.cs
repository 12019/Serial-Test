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

namespace CsGL.Pointers
{
	/**
	 * Inherits from PVoid, int8 pointer type.
	 * @see PVoid
	 */
	public unsafe sealed class PInt8 : PVoid
	{
		/**
		 * Constructor/Initializer for n atomic elements.
		 * @param n The number of int8s to allocate upon construction.
		 * @see PVoid
		 */
		public PInt8(int n) : base(n)
		{
		}

		/**
		 * Returns sizeof(sbyte), 1 bytes as per MS specification, this is the 'atomic' element size.
		 * @see PVoid
		 */
		public override int SizeOfType() { return sizeof(sbyte); }
		
		/**
		 * Array like accessor, see PVoid.check for exception handling.
		 * @param index The index of the int8 to get.
		 * @see PVoid
		 */
		public sbyte this[int index]
		{
			get 
			{ 
				check(index);
				return ((sbyte*) data)[index];
			}
			set 
			{ 
				check(index);
				((sbyte*) data)[index] = value;
			}
		}
		
		/**
		 * Casts a PInt8 to an unsafe pointer to int8 (int8*)
		 * @param p The PInt8 to cast to int8*
		 */
		public static implicit operator sbyte*(PInt8 p) { return (sbyte*) p.data; }

		/**
		 * Copies a C# int8 array into a PInt8 class.
		 * @param dst The destination allocated memory.	
		 * @param p0 The index to start copying to.
		 * @param src The source int8 array.
		 * @param p1 The index to start copying from.
		 * @param len The number of atomic (int8) elements to copy.
		 */
		public static void Copy(PInt8 dst, int p0, sbyte[] src, int p1, int len)
		{
			fixed(sbyte* psrc = &src[0])
				dst.Copy(dst.data, dst.length, p0, psrc, src.Length, p1, len);
		}

		/**
		 * Copies a PInt8 into a C# array.
		 * @param dst The destination C# array.
		 * @param p0 The index to start copying to.
		 * @param src The allocated memory array to copy from.
		 * @param p1 The index to start copying from.
		 * @param len The number of atomic (int8) elements to copy.
		 */
		public static void Copy(sbyte[] dst, int p0, PInt8 src, int p1, int len)
		{
			fixed(sbyte* pdst = &dst[0])
				src.Copy(pdst, dst.Length, p0, src.data, src.length, p1, len);
		}

		/**
		 * See PVoid.
		 * @see PVoid
		 */
		public static void Copy(PInt8 dst, int p0, PInt8 src, int p1, int len)
		{
			dst.Copy(dst.data, dst.length, p0, src.data, src.length, p1, len);
		}
	}
}

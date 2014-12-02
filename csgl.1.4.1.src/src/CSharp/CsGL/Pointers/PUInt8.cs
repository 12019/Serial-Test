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
	 * Inherits from PVoid, uint8 pointer type.
	 * @see PVoid
	 */
	public unsafe sealed class PUInt8 : PVoid
	{
		/**
		 * Constructor/Initializer for n atomic elements.
		 * @param n The number of uint8s to allocate upon construction.
		 * @see PVoid
		 */
		public PUInt8(int n) : base(n)
		{
		}

		/**
		 * Returns sizeof(byte), 1 byte as per MS specification, this is the 'atomic' element size.
		 * @see PVoid
		 */
		public override int SizeOfType() { return sizeof(byte); }
		
		/**
		 * Array like accessor, see PVoid.check for exception handling.
		 * @param index The index of the uint8 to get.
		 * @see PVoid
		 */
		public byte this[int index]
		{
			get 
			{ 
				check(index);
				return ((byte*) data)[index];
			}
			set 
			{ 
				check(index);
				((byte*) data)[index] = value;
			}
		}
		
		/**
		 * Casts a PUInt8 to an unsafe pointer to uint8 (uint8*)
		 * @param p The PUInt8 to cast to uint8*
		 */
		public static implicit operator byte*(PUInt8 p) { return (byte*) p.data; }

		/**
		 * Copies a C# uint8 array into a PUInt8 class.
		 * @param dst The destination allocated memory.	
		 * @param p0 The index to start copying to.
		 * @param src The source uint8 array.
		 * @param p1 The index to start copying from.
		 * @param len The number of atomic (uint8) elements to copy.
		 */
		public static void Copy(PUInt8 dst, int p0, byte[] src, int p1, int len)
		{
			fixed(byte* psrc = &src[0])
				dst.Copy(dst.data, dst.length, p0, psrc, src.Length, p1, len);
		}

		/**
		 * Copies a PUInt8 into a C# array.
		 * @param dst The destination C# array.
		 * @param p0 The index to start copying to.
		 * @param src The allocated memory array to copy from.
		 * @param p1 The index to start copying from.
		 * @param len The number of atomic (uint8) elements to copy.
		 */
		public static void Copy(byte[] dst, int p0, PUInt8 src, int p1, int len)
		{
			fixed(byte* pdst = &dst[0])
				src.Copy(pdst, dst.Length, p0, src.data, src.length, p1, len);
		}

		/**
		 * See PVoid.
		 * @see PVoid
		 */
		public static void Copy(PUInt8 dst, int p0, PUInt8 src, int p1, int len)
		{
			dst.Copy(dst.data, dst.length, p0, src.data, src.length, p1, len);
		}
	}
}

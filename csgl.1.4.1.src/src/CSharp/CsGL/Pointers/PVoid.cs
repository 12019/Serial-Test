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
using CsGL.Util;

namespace CsGL.Pointers
{
	/**
	  * PVoid provides a basic class for the void* type, it inherits from
	  * Pointer (see the Pointer header file) and IDisposable interface for
	  * correctly disposing the pointer, PVoid is abstract class and is not
	  * used 'directly'.
	  */
	public abstract unsafe class PVoid : Pointer, IDisposable
	{
		/**
		  * void* data: The unsafe pointer to the data contained within the class. 
		  */ 
		protected void* data;
		/**
		  * length: the length of the data in units returned from <a href="#SizeOfType">SizeOfType</a>.
		  * @see SizeOfType
		  */
		protected int length;
		
		/**
		  * Constructor/Initializer for n values, owner is set to true..
		  * @param n The size of the array in units of <a href="#SizeOfType">SizeOfType</a>
		  * @see SizeOfType
		  */ 
		public PVoid(int n)
		{
			data = Calloc(n * SizeOfType());
			length = n;
		}
		
		/**
		  * A simple passthrough call to the <a href="#Dispose">Dispose</a> function.
		  */
		~PVoid() { Dispose(); }

		/**
		  * Abstract method which gives the atomic size of the type being allocated.
		  */
		public abstract int SizeOfType();
		
		/**
		  * Properly disposes of the memory through calls to the FreeFct delegate, if
		  * the memory cannot be successfully deallocated the pointer is set to NULL and
		  * the length is reduced to 0.
		  */
		public void Dispose()
		{
			if(data == (void*) 0x0)
				return;
			GC.SuppressFinalize(this);
			try { Free(data); }
			finally
			{
				data = (void*) 0x0;
				length = 0;
			}
		}
		
		/**
		  * Length accessor, procedural.
		  */
		public int Length { get { return length; } }

		/**
		  * Throws an ObjectDisposedException("Pointer already freed") if the PVoid is
		  * set to the null or an IndexOutOfRangeException() if this index would be
		  * out of range.
		  * @param index The index to check against the memory array.
		  */
		protected void check(int index)
		{
			if((void*) data == (void*) 0x0)
				throw new ObjectDisposedException("Pointer already freed");
			if(index<0 || index >= length)
				throw new IndexOutOfRangeException();
		}
		
		/**
		  * Casts the class to an IntPtr, see the Pointer header source.
		  */
		public static implicit operator IntPtr(PVoid p) { return (IntPtr) p.data; }
		/**
		  * Casts the class to a void*, see the Pointer header source.
		  */
		public static explicit operator void*(PVoid p)  { return p.data; }

		/**
		  * Copies from src to dst, copies len SizeOfType atomic elements, starting at
		  * p0 in dst and at p1 in src, throws ObjectDisposedException if either is NULL,
		  * throws IndexOutOfRangeException if either would write beyond the end of their
		  * allocation.
		  * @param dst The memory to be copied into.
		  * @param dstlen The length of dst.
		  * @param p0 The place to begin copying to.
		  * @param src The memory to be copied from.
		  * @param srclen The length of src.
		  * @param p1 The place to begin copying from.
		  * @param len The number of atomic elements (see <a href="#SizeOfType">SizeOfType</a>) to be
		  * copied.
		  */
		protected void Copy(void* dst, int dstlen, int p0, void* src, int srclen, int p1, int len)
		{
			if(dst == (void*) 0x0)
				throw new ObjectDisposedException("dst");
			if(src == (void*) 0x0)
				throw new ObjectDisposedException("src");
			if(p0<0 || p1<0 || p0+len>dstlen || p1+len>srclen)
				throw new IndexOutOfRangeException();
			
			dst = (void*) (p0 * SizeOfType() + (byte*) dst);
			src = (void*) (p1 * SizeOfType() + (byte*) src);
			Memcpy(dst, src, len * SizeOfType());
		}
	}
}

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

namespace CsGL.Util
{
	/**
	 * This class allocate standart C memory. could be usefull 
	 * to have unmoving address space.
	 */
	public unsafe class Pointer : CsGL.OSLib
	{
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
		static extern void* csgl_pointer_malloc(int size);
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
		static extern void* csgl_pointer_calloc(int size);

		public static void* Malloc(int size)
		{
			void* p = csgl_pointer_malloc(size);
			if(p == (void*) 0x0)
				throw new OutOfMemoryException("Cannot alloc "+size+" byte(s).");
			return p;
		}
		public static IntPtr SMalloc(int size) { return (IntPtr) Malloc(size); }
		
		public static void* Calloc(int size)
		{
			void* p = csgl_pointer_calloc(size);
			if(p == (void*) 0x0)
				throw new OutOfMemoryException("Cannot alloc "+size+" byte(s).");
			return p;
		}
		public static IntPtr SCalloc(int size) { return (IntPtr) SCalloc(size); }
		
		[DllImport(CSGL, EntryPoint="csgl_pointer_free", CallingConvention=CallingConvention.Cdecl)]
		public static extern void Free(void* ptr);
		[DllImport(CSGL, EntryPoint="csgl_pointer_free", CallingConvention=CallingConvention.Cdecl)]
		public static extern void SFree(IntPtr ptr);
		
		[DllImport(CSGL, EntryPoint="csgl_pointer_memset", CallingConvention=CallingConvention.Cdecl)]
		public static extern void Memset(void* dst, byte val, int size);
		[DllImport(CSGL, EntryPoint="csgl_pointer_memset", CallingConvention=CallingConvention.Cdecl)]
		public static extern void SMemset(IntPtr dst, byte val, int size);
		
		[DllImport(CSGL, EntryPoint="csgl_pointer_memcpy", CallingConvention=CallingConvention.Cdecl)]
		public static extern void Memcpy(void* dest, void* src, int size);
		[DllImport(CSGL, EntryPoint="csgl_pointer_memcpy", CallingConvention=CallingConvention.Cdecl)]
		public static extern void SMemcpy(IntPtr dest, IntPtr src, int size);
	}
}

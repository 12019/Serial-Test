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
using System.Collections;
using System.Threading;
using System.Runtime.InteropServices;

namespace CsGL.Util
{
	/**
	 * This class is an helper class to generate any call to any 
	 * <B>WINAPI</B> C-function pointer. (__stdcall on Windows, __cdecl on CE).
	 * To issue a given call you have 2 or eventually 3 step to follow.
	 * <ol>
	 * 	<li>you should call Prepare with the correct function pointer
	 *  and the stack size of all arguments. use IntPtr.Size to have
	 *  size of pointer
	 *  <li> then call your C-function pointer with the corresponding
	 *  Call(..) static method.
	 *  <li> eventually, if it is not already implemented, you will 
	 *  have to create your Call method.
	 * </ol>
	 * To summarize use it like this:
	 * <pre>
	 * IntPtr fct = GL.GetProc("glArrayElementEXT");
	 * CFunction.Prepare(fct, 4);
	 * CFunction.Call(1);
	 * </pre>
	 * 
	 * @see Prepare
	 * @see Call
	 */
	public unsafe class CFunction : CsGL.OSLib
	{
	    [StructLayout(LayoutKind.Sequential)]
		private struct CALLINFO 
		{
			public int stacksize;
			public IntPtr cfunction;
		}
		private class HOLDER
		{
			public CALLINFO ci = new CALLINFO();
		}
		
	    private delegate CALLINFO GetInfoCallBack();
	    private static readonly GetInfoCallBack getInfoCallBack = new GetInfoCallBack(getInfo);
		
		// return thread local CALLINFO struct
	    private static HOLDER getInfoH()
	    {
	    	HOLDER h = (HOLDER) Thread.GetData(callIS);
	    	if(h == null) {
	    		h = new HOLDER();
	    		Thread.SetData(callIS, h);
	    	}
	        return h;
	    }
	    private static CALLINFO getInfo() { return getInfoH().ci; }
		private static LocalDataStoreSlot callIS = Thread.AllocateDataSlot();
	    
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
    	private static extern void csgl_call_init(GetInfoCallBack callback);
		static CFunction()
		{
			csgl_call_init(getInfoCallBack);
		}
		
		// --------------------------------------
		// public stuff here ...
		
		/**
		 * the most important call before the call itself.
		 * prepare the function to be called.
		 * 
		 * @param cfunction the C-function pointer to be called. 
		 * should follow WINAPI call type (i.e. __stdcall on window, __cdecl on CE)
		 * @param stacksize the stack size of all arguments. use
		 * IntPtr.Size to find out pointer/array stack size. and use
		 * the StackSize function to calculate it.
		 */
		public static void Prepare(IntPtr pWINAPIFunction, int stacksize)
		{
			HOLDER h = getInfoH();
			h.ci.cfunction = pWINAPIFunction;
			h.ci.stacksize = stacksize;
		}
		
		/**
		 * return the stack size for a list of argument of given size.
		 * Here I assume that each element occupy an integral number of
		 * times the size of one register on the stack and that element
		 * bigger than a register simple get cut among as many register as
		 * needed, but no more. And that the size of a register is equal
		 * to IntPtr.Zero.
		 * @param elemSize the size of each element
		 */
		public static int StackSize(params int[] elemSize)
		{
			int regSize = IntPtr.Size;
			int ret = 0;
			for(int i=0; i<elemSize.Length; i++) {
				if(elemSize[i] <1) 
					throw new ArgumentException("size negative or null");
				ret += (elemSize[i] - 1) / regSize + 1;
			}
			return ret * regSize;
		}
		
		
		/**
		 * the base prototype. all prototypes should look
		 * like this:
		 * <pre>
		 * [DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		 * public static extern void Call(--my arguments, whatever they are--)
		 * </pre>
		 * or, alternatively you could make a prototype with a return type
		 * like this:
		 * <pre>
		 * [DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		 * public static extern Type TypeCall(--my arguments, whatever they are--)
		 * </pre>
		 */
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
	    public static extern void Call();
		
#region call put any function prototype you want here..
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint arg4, uint arg5, void* arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint arg4, uint arg5, IntPtr arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint arg4, uint arg5, byte[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint arg4, uint arg5, sbyte[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint arg4, uint arg5, short[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint arg4, uint arg5, ushort[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint arg4, uint arg5, int[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint arg4, uint arg5, uint[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint arg4, uint arg5, float[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint arg4, uint arg5, double[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, uint arg4, uint arg5, void* arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, uint arg4, uint arg5, IntPtr arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, uint arg4, uint arg5, byte[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, uint arg4, uint arg5, sbyte[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, uint arg4, uint arg5, short[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, uint arg4, uint arg5, ushort[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, uint arg4, uint arg5, int[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, uint arg4, uint arg5, uint[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, uint arg4, uint arg5, float[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, uint arg4, uint arg5, double[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int* arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, IntPtr arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, float* arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, float[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, int arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, void* arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, IntPtr arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, byte[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, sbyte[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, short[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, ushort[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, float[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, double[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(float arg1, float arg2, float arg3, float arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, byte arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, uint arg3, uint arg4, void* arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, uint arg3, uint arg4, IntPtr arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, uint arg3, uint arg4, byte[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, uint arg3, uint arg4, sbyte[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, uint arg3, uint arg4, short[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, uint arg3, uint arg4, ushort[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, uint arg3, uint arg4, int[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, uint arg3, uint arg4, uint[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, uint arg3, uint arg4, float[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, uint arg3, uint arg4, double[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, byte arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, void* arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, IntPtr arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, byte[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, sbyte[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, short[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, ushort[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, int[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, uint[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, float[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, double[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, float arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, int arg5, int arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, void* arg7, void* arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, IntPtr arg7, IntPtr arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, byte[] arg7, byte[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, sbyte[] arg7, sbyte[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, short[] arg7, short[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, ushort[] arg7, ushort[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, int[] arg7, int[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, uint[] arg7, uint[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, float[] arg7, float[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int arg4, uint arg5, uint arg6, double[] arg7, double[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, void* arg4, void* arg5, void* arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, byte[] arg4, byte[] arg5, byte[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, sbyte[] arg4, sbyte[] arg5, sbyte[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, short[] arg4, short[] arg5, short[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, ushort[] arg4, ushort[] arg5, ushort[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int[] arg4, int[] arg5, int[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint[] arg4, uint[] arg5, uint[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, float[] arg4, float[] arg5, float[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, double[] arg4, double[] arg5, double[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, uint arg5, void* arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, uint arg5, IntPtr arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, uint arg5, byte[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, uint arg5, sbyte[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, uint arg5, short[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, uint arg5, ushort[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, uint arg5, int[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, uint arg5, uint[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, uint arg5, float[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, uint arg5, double[] arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, uint arg8, uint arg9, void* arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, uint arg8, uint arg9, IntPtr arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, uint arg8, uint arg9, byte[] arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, uint arg8, uint arg9, sbyte[] arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, uint arg8, uint arg9, short[] arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, uint arg8, uint arg9, ushort[] arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, uint arg8, uint arg9, int[] arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, uint arg8, uint arg9, uint[] arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, uint arg8, uint arg9, float[] arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, uint arg8, uint arg9, double[] arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, uint arg10, void* arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, uint arg10, IntPtr arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, uint arg10, byte[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, uint arg10, sbyte[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, uint arg10, short[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, uint arg10, ushort[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, uint arg10, int[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, uint arg10, uint[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, uint arg10, float[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, uint arg10, double[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, void* arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, IntPtr arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, byte[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, sbyte[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, short[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, ushort[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, uint[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, float[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, double[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, void* arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, IntPtr arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, byte[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, sbyte[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, short[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, ushort[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, uint[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, float[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, double[] arg8);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, int arg8, void* arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, int arg8, IntPtr arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, int arg8, byte[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, int arg8, sbyte[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, int arg8, short[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, int arg8, ushort[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, int arg8, float[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, int arg8, double[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, uint arg5, int arg6, void* arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, uint arg5, int arg6, IntPtr arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, uint arg5, int arg6, byte[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, uint arg5, int arg6, sbyte[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, uint arg5, int arg6, short[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, uint arg5, int arg6, ushort[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, uint arg5, int arg6, int[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, uint arg5, int arg6, uint[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, uint arg5, int arg6, float[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, uint arg5, int arg6, double[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, uint arg7, int arg8, void* arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, uint arg7, int arg8, IntPtr arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, uint arg7, int arg8, byte[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, uint arg7, int arg8, sbyte[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, uint arg7, int arg8, short[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, uint arg7, int arg8, ushort[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, uint arg7, int arg8, int[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, uint arg7, int arg8, uint[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, uint arg7, int arg8, float[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, uint arg7, int arg8, double[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, int arg10, void* arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, int arg10, IntPtr arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, int arg10, byte[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, int arg10, sbyte[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, int arg10, short[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, int arg10, ushort[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, int arg10, int[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, int arg10, uint[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, int arg10, float[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, uint arg9, int arg10, double[] arg11);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, void* arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, IntPtr arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, byte[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, sbyte[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, short[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, ushort[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, float[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, double[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, double arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, double* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, IntPtr arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, double[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, float arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, float* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, float[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, short arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, short* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, short[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, double arg2, double arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, float arg2, float arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, short arg2, short arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, double arg2, double arg3, double arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, float arg2, float arg3, float arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, int arg3, int arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, short arg2, short arg3, short arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, double arg2, double arg3, double arg4, double arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, float arg2, float arg3, float arg4, float arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, short arg2, short arg3, short arg4, short arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(float arg1, byte arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(float arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(float* arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(IntPtr arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(float[] arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(double arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(double* arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(double[] arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int* arg2, int* arg3, int arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, IntPtr arg2, IntPtr arg3, int arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int[] arg2, int[] arg3, int arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int* arg2, uint arg3, void** arg4, int arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, IntPtr arg2, uint arg3, IntPtr arg4, int arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int[] arg2, uint arg3, IntPtr arg4, int arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(byte arg1, byte arg2, byte arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(byte* arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(byte[] arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(double arg1, double arg2, double arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(float arg1, float arg2, float arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, int arg2, int arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int* arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int[] arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(short arg1, short arg2, short arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(short* arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(short[] arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint* arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint[] arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(ushort arg1, ushort arg2, ushort arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(ushort* arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(ushort[] arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint arg2, int arg3, void* arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint arg2, int arg3, IntPtr arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint arg2, int arg3, byte[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint arg2, int arg3, sbyte[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint arg2, int arg3, short[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint arg2, int arg3, ushort[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint arg2, int arg3, int[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint arg2, int arg3, uint[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint arg2, int arg3, float[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint arg2, int arg3, double[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(double arg1, double arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(float arg1, float arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, int arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(short arg1, short arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, void* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, IntPtr arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, byte[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, sbyte[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, short[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, ushort[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, int[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, float[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, double[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern IntPtr IntPtrCall(int arg1, float arg2, float arg3, float arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(void* arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(sbyte[] arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, uint arg5, uint arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, uint arg5, uint arg6, uint arg7, byte arg8, byte arg9, byte arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, float* arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, IntPtr arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, float[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, int* arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, int[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, float* arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int* arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, uint* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern byte byteCall(int arg1, uint* arg2, byte* arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern byte byteCall(int arg1, IntPtr arg2, IntPtr arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern byte byteCall(int arg1, uint[] arg2, byte[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, double* arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, byte* arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, byte[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, double* arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, double[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, void** arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern byte byteCall(uint arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, byte* arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, IntPtr arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, byte[] arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, float arg3, float arg4, float arg5, float arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, double arg3, double arg4, double arg5, double arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, void* arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, IntPtr arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, byte[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, sbyte[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, short[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, ushort[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, int[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, uint[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, float[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, double[] arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, byte arg3, byte arg4, byte arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, short* arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, float* arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, double* arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, byte* arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, byte arg8, void* arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, byte arg8, IntPtr arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, byte arg8, byte[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, byte arg8, sbyte[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, byte arg8, short[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, byte arg8, ushort[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, byte arg8, int[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, byte arg8, uint[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, byte arg8, float[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, int arg6, int arg7, byte arg8, double[] arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, byte arg6, void* arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, byte arg6, IntPtr arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, byte arg6, byte[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, byte arg6, sbyte[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, byte arg6, short[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, byte arg6, ushort[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, byte arg6, int[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, byte arg6, uint[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, byte arg6, float[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4, int arg5, byte arg6, double[] arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, byte* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, short* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, int* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, float* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, double* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1, ushort* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(int arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(uint arg1);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, uint arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(uint arg1, uint arg2, uint arg3, uint arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, void* arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, sbyte[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, short[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, ushort[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint[] arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, ushort* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, ushort[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(uint arg1, uint arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(uint arg1, uint arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern byte byteCall(uint arg1, uint arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, uint arg5, uint arg6, uint arg7);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, uint arg5, uint arg6, uint arg7, uint arg8, uint arg9, uint arg10);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, uint arg5, uint arg6, uint arg7, uint arg8, uint arg9, uint arg10, uint arg11, uint arg12, uint arg13);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, uint arg5, uint arg6, uint arg7, uint arg8, uint arg9);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, uint arg4, uint arg5, uint arg6, uint arg7, uint arg8, uint arg9, uint arg10, uint arg11, uint arg12);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, void* arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, sbyte[] arg2);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, uint arg3, int arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, byte arg2, byte arg3, byte arg4);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(int arg1, void* arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(int arg1, IntPtr arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(int arg1, byte[] arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(int arg1, sbyte[] arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(int arg1, short[] arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(int arg1, ushort[] arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(int arg1, int[] arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(int arg1, uint[] arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(int arg1, float[] arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern uint uintCall(int arg1, double[] arg2, uint arg3);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, void* arg4, uint arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, IntPtr arg4, uint arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, byte[] arg4, uint arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, sbyte[] arg4, uint arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, short[] arg4, uint arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, ushort[] arg4, uint arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, int[] arg4, uint arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint[] arg4, uint arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, float[] arg4, uint arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, double[] arg4, uint arg5);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, int arg2, uint arg3, int arg4, uint arg5, uint arg6);
		[DllImport(CSGL, EntryPoint="csgl_call_call", CallingConvention=CallingConvention.Winapi)]
		public static extern void Call(uint arg1, uint arg2, int arg3, uint arg4, uint arg5);
#endregion
	}
}

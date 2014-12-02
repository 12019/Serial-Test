using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;

/**
 * this function help to generate multiple level of polymorphic
 * function. <br>
 * in case of a pointer argument. there is 3 level of polymorphic
 * function :
 * <ol>
 * <li> the first is the original (unsafe) one, such as void*, int*, ..
 * <li> the second is the CsGL type CsGL.Pointer.PType/IntPtr as argument
 * or RType as return type
 * <li> the last is the managed array corresponding type. there is only
 * one such all for a type* but 10 for void*
 * </ol>
 */
public class CallHelper
{
	Type GetCallClass()
	{
		try {
			Assembly a = Assembly.LoadWithPartialName("csgl");
			if(a==null) {
				Console.Error.WriteLine("warning: Can't load CsGL");
				Console.Error.WriteLine("\t\t==> Add all");
				return null;
			}
			Type cfuncType = a.GetType("CsGL.Util.CFunction");
			if(cfuncType==null) {
				Console.Error.WriteLine("warning: Can't find CsGL.Util.CFunction");
				Console.Error.WriteLine("\t\t==> Add all");
				return null;
			}
			return cfuncType;
		}
		catch(Exception ex) {
			Console.Error.WriteLine("warning: Can't browse CsGL.Util.CFunction because:");
			Console.Error.WriteLine("\t\t==> Add all");
			Console.WriteLine(ex.Message);
			Console.WriteLine(ex.StackTrace);
			return null;
		}
	}
	Hashtable already;
	Hashtable GetSymbols()
	{
		if(already==null)
			already = CreateSymbols();
		return already;
	}
	Hashtable CreateSymbols()
	{
		Hashtable ret = new Hashtable();
		Type t = GetCallClass();
		// put function already defined...
		// the format should be the same than in callString(..)
		if(t != null) {
			MethodInfo[] mis = t.GetMethods();
			foreach(MethodInfo mi in mis) {
				if(!mi.IsPublic)
					continue;
				
				StringBuilder sb = new StringBuilder();
				sb.Append(name(mi.ReturnType));
				sb.Append(' ');
				sb.Append(mi.Name);
				sb.Append('(');
				ParameterInfo[] pi = mi.GetParameters();
				if(pi!=null)
					for(int j=0; j<pi.Length; j++) {
						if(j != 0)
							sb.Append(", ");
						sb.Append(name(pi[j].ParameterType));
						sb.Append(" arg"+(j+1));
					}
				sb.Append(')');
				
				string s = sb.ToString();
				ret[s] = s;
			}
		}
		return ret;
	}
	static string name(Type t)
	{
		string s = t.Name;
		if(s.StartsWith("Void"))
			s = "void"+s.Substring(4);
		else if(s.StartsWith("Byte"))
			s = "byte"+s.Substring(4);
		else if(s.StartsWith("UInt8"))
			s = "byte"+s.Substring(5);
		else if(s.StartsWith("Int8"))
			s = "sbyte"+s.Substring(4);
		else if(s.StartsWith("SByte"))
			s = "sbyte"+s.Substring(5);
		else if(s.StartsWith("UInt16"))
			s = "ushort"+s.Substring(6);
		else if(s.StartsWith("Int16"))
			s = "short"+s.Substring(5);
		else if(s.StartsWith("UInt32"))
			s = "uint"+s.Substring(6);
		else if(s.StartsWith("Int32"))
			s = "int"+s.Substring(5);
		else if(s.StartsWith("Float"))
			s = "float"+s.Substring(5);
		else if(s.StartsWith("Single"))
			s = "float"+s.Substring(6);
		else if(s.StartsWith("Double"))
			s = "double"+s.Substring(6);
		return s;
	}

	public String OutputFilename;
	TextWriter output;
	
	public bool ShouldAdd(int level, GLType ret, GLArgs args)
	{
		Type cfunc = GetCallClass();
		if(cfunc==null)
			return true;
		return true;
	}
	
	/** take care of the CFunction.Call prototype, if needed */
	public void checkCall(int level, GLType ret, GLArgs args)
	{
		string s = callString(level, ret, args);
		Hashtable symb = GetSymbols();
		if(symb.Contains(s))
			return;
		symb[s] = s;
		
		TextWriter tw = GetF();
		tw.WriteLine("\t\t[DllImport(CSGL, EntryPoint=\"csgl_call_call\")]");
		tw.Write("\t\tpublic static extern "+s+";");
		tw.WriteLine();
	}

	// get the call representation
	// the format should be the same than CreateSymbols()
	string callString(int level, GLType ret, GLArgs args)
	{
		StringBuilder sb = new StringBuilder();
		sb.Append(ret.ToString(level, true, false));
		sb.Append(' ');
		if(!ret.IsVoid)
			sb.Append(ret.ToString(level, true, true));
		sb.Append("Call(");
		if(args!=null)
			for(int i=0,n=args.types.Count; i<n; i++) {
				if(i!=0)
					sb.Append(", ");
				sb.Append((args.types[i] as GLType).ToString(level, false, false));
				sb.Append(" arg"+(i+1));
			}
		sb.Append(')');
		return sb.ToString();
	}
	
	TextWriter GetF()
	{
		if(output == null) {
			if(OutputFilename==null)
				OutputFilename = "newCall.cs";
			output = new StreamWriter(OutputFilename);
		}
		return output;
	}
	public void finish()
	{
		if(output != null) {
			output.Flush();
			Console.Out.WriteLine("new call stored in \""+OutputFilename+"\"");
		}
		else
			Console.Out.WriteLine("no new call generated.");
		Console.Out.Flush();
	}
}

using antlr;
using antlr.collections;
using System;
using System.Collections;
using System.IO;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyTitle("GLGenerator")]
[assembly: AssemblyDescription("OpenGL-C# extension generator for CsGL")]
[assembly: AssemblyCopyright("Lloyd Dupont <lloyd@galador.net>, 2002")]

public class GLGenerator
{
	const string NAME = "extension.cs";
	AST tree;
	GLTranslator translator;
	TextWriter output = Console.Out;
	CallHelper cHelper = new CallHelper();
	internal int numConsts, numFunctions;

	public GLGenerator(AST aTree)
	{
		tree = aTree;
        translator = new GLTranslator();
		translator.Generator = this;
	}
	public TextWriter Output
	{
		get { return output; }
		set { output = value; }
	}
	public void generate()
	{
		header();
		pclass();
		output.Flush();
		finish();
		cHelper.finish();
	}
	void finish()
	{
		Console.Write(numConsts+" constants created, ");
		Console.Write(numFunctions+" functions generated, ");
		Console.WriteLine("in "+NAME+'.');
		Console.Out.Flush();
	}
	public void pclass()
	{
        println("namespace CsGL.OpenGL");
        println("{");
        IndentLevel ++;
        println("[Serializable]");
        println("public abstract unsafe class MyExtension : GL");
        println("{");
        IndentLevel ++;
			translator.stage2(tree);
			newline();
		
			translator.stage3(tree);
			newline();
		
	        pget();
        IndentLevel --;
		println("}");
        IndentLevel --;
        println("}");
	}
	
	public void pfunction(GLType ret, string name, GLArgs args)
	{
		int lArgs = args==null ? 0 : args.Level;
		
		if(lArgs < 2)
			pfunction(1, ret, name, args);
		else
			for(int i=0; i<lArgs; i++)
				pfunction(i, ret, name, args);
	}
	void pfunction(int level, GLType ret, string name, GLArgs args)
	{
		numFunctions ++;
		int i,n;
		
		indent();
		print("public ");
		print(ret.ToString(level, true, false));
		print(" ");
		print(name);
		print("(");
		if(args!=null)
			for(i=0,n=args.types.Count; i<n; i++) {
				if(i!=0)
					print(", ");
				print((args.types[i] as GLType).ToString(level, false, false));
				print(" ");
				print(args.names[i]);
			}
		print(")");
		newline();
		
		println("{");
		IndentLevel ++;
		
		println("FctInfo fi = "+GetName+"(\""+name+"\", true);");
		println("if(fi == null)");
		if(ret.IsVoid)
			println("\treturn;");
		else
			println("\treturn ("+ret.ToString(level, true, false)+") 0;");
            
		println("if(fi.stack_size == -1)");
			indent();
			print("\tfi.stack_size = CFunction.StackSize(");
            if(args!=null)
    			for(i=0,n=args.types.Count; i<n; i++) {
    				if(i!=0)
    					print(", ");
                    GLType t = args.types[i] as GLType;
                    if(t.IsPointer)
                    	print("IntPtr.Size");
                    else
                    	print("" + t.Size);
    			}
            print(");\n");
		
		println("CFunction.Prepare(fi.function_ptr, fi.stack_size);");
		
		indent();
		if(ret.IsVoid)
			print("CFunction.Call(");
		else {
			print("return CFunction.");
			print(ret.ToString(level, true, true));
			print("Call(");
		}
		if(args!=null)
			for(i=0,n=args.types.Count; i<n; i++) {
				if(i!=0)
					print(", ");
				print(args.names[i]);
			}
		print(");");
		newline();
		
		IndentLevel --;
		println("}");
		
		cHelper.checkCall(level, ret, args);
	}
	
	public string GetName = "_getf";
	public void pget()
	{
        println("class FctInfo");
        println("{");
        IndentLevel ++;
            println("public FctInfo(IntPtr p) { function_ptr = p; }");
            println("public IntPtr function_ptr;");	
            println("public int    stack_size = -1;");
        IndentLevel --;
        println("}");
        println("private ContextLocal _fctsTable;");
        println("private Hashtable    _globalFct;");
        println("private FctInfo      "+GetName+"(string name, bool contextLocal)");
        println("{");
        IndentLevel ++;
            println("Hashtable fcts = null;");
            println("if(contextLocal) {");
	        IndentLevel ++;
				println("if(_fctsTable==null)");
				println("\t_fctsTable = new ContextLocal();");
				println("fcts = (Hashtable) _fctsTable.Value;");
				println("if(fcts == null) {");
				println("\tif(OpenGLContext.Current == null)");
				println("\t\treturn null;");
				println("\tfcts = new Hashtable();");
				println("\t_fctsTable.Value = fcts;");
				println("}");
	        IndentLevel --;
			println("} else {");
	        IndentLevel ++;
				println("if(_globalFct==null)");
				println("\t_globalFct = new Hashtable();");
				println("fcts = _globalFct;");
	        IndentLevel --;
			println("}");
			println("FctInfo o = (FctInfo) fcts[name];");
			println("if(o == null) {");
			println("\to = new FctInfo(GetProc(name, true));");
			println("\tfcts[name] = o;");
			println("}");
			println("return o;");
		IndentLevel --;
        println("}");
	}
	public void header()
	{
		DateTime dt = DateTime.Now;
		DateTimeFormatInfo dfi = new DateTimeFormatInfo();
        println("// created by GLGenerator on "+dt.ToString(dfi));
        println("// check last release of GLGenerator at http://csgl.sourceforge.net");
        println("using System;");
        println("using System.Collections;");
        println("using CsGL.OpenGL;");
        println("using CsGL.Util;");
        newline();
	}
	public void println(object o) 
	{
		indent();
		output.WriteLine(o);
	}
	public void print(object o)
	{
		output.Write(o);
	}
	public void newline()
	{
		output.WriteLine();
	}
	public void indent()
	{
		for(int i=0; i<IndentLevel; i++)
			output.Write('\t');
	}
	public int IndentLevel = 0;
	
	static void usage()
	{
		Console.WriteLine("usage:");
		Console.WriteLine("\tgenerator <header file name>.h");
		Console.WriteLine("caution: it will create/overwrite files "+NAME+", newCall.cs");
		Console.Out.Flush();
	}
    public static void Main(string[] arg)
    {
    	if(arg==null || arg.Length!=1) {
    		usage();
    		return;
    	}
    	long t0 = DateTime.Now.Ticks;
    	GLGenerator gen = new GLGenerator(parseit(arg[0]));
    	gen.Output = new StreamWriter(NAME);
    	gen.generate();
    	
    	t0 = DateTime.Now.Ticks - t0;
    	Console.Out.WriteLine("parsing tooks "+(t0*1e-7)+" second(s)...");
    }
    public static AST parseit(string file)
    {
        FileStream  fs  = new FileStream(file, FileMode.Open);
        GLLexer nrl = new GLLexer(fs);
        GLParser nrp = new GLParser(nrl);
    	
    	nrp.parse();
        fs.Close();
    	
        return nrp.getAST();
    }
}

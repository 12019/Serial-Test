import java.io.*;
import java.util.*;
import java.text.*;
import antlr.*;
import antlr.collections.*;

// of course you need to comment the language=C# option for this
// usefull to test your tree generation
public class ShowTree
{
    public static void main(String[] arg)
    	throws Exception
    {
        treeit(arg[0]);
    }
    static void treeit(String file)
		throws Exception
    {
        FileInputStream  fis  = new FileInputStream(file);
        GLLexer  nrl = new GLLexer(fis);
        GLParser nrp = new GLParser(nrl);
        nrp.parse();
        fis.close();
        
        AST ast = nrp.getAST();
        CommonAST cast = new CommonAST();
        cast.addChild(ast);
        antlr.debug.misc.ASTFrame f = new antlr.debug.misc.ASTFrame("OpenGL", cast);
        f.show();
    }
}

options {
	language = "CSharp";
}

/**
* The translator. It reads the AST structure and output
* them as C# data or functions
*
* @version 1.0
* @author Lloyd Dupont <a href=mailto:lloyd@galador.net>lloyd@galador.net</a>
*/
class GLTranslator extends TreeParser;
options {
	importVocab = GLExt;
}
{
	GLGenerator gen;
	public GLGenerator Generator
	{
		set { gen = value; }
		get { return gen;  }
	}
	
	CodeHelper helper = new CodeHelper();
}

// print constants
// and get friendly name for function type
stage2
	: ( pconsts | getFctName | . ) *
	;
pconsts
	:	#(CONST_DEF name:ID value:NUM) 
		{	// generate constant
			gen.println("public const uint "+name+" = "+value+';');
			gen.numConsts ++;
		}
	;
getFctName
	:	#(FUNC type:ID fctName:ID) 
    	{	// save name
           helper.SetTypeName(type.getText(), fctName.getText());
        }
    ;
	
// print functions and generate CFunction missing call
stage3
	: ( pfunc | . ) *
	;
pfunc
{
	GLType ret;
	GLArgs args = null;
}
	:	#(FUNC_DEF ret=type name:ID (args=arguments)?)
	{	// print function
		gen.pfunction(ret, helper.GetTypeName(name.getText()), args);
	}
	;
arguments returns [GLArgs args = new GLArgs()]
{
	GLType aType;
}
	:	#(PARAMS 
			( aType=type id:ID { args.Add(aType, id.getText()); } ) +
		)
    ;
type returns [GLType aType = null]
	:	#(TYPE 
			t:. { aType = new GLType(t.getText()); } 
			(STAR { aType.stars ++; }) *
		)
	;

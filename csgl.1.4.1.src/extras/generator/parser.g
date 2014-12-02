/*
This is a grammar file for ANTLR (http://www.antlr.org)
It read a (simplified) extension header and produce an extension .cs file

simplified mean you just let in your header 4 type of entry
- #define ACONST AVALUE
- typedef blablabla glExtensionFunction param-blablabla
- extern glExtensionFunction functionName
- C/C++ style comment. they are not used but does not cause parse error
*/
options {
	language = "CSharp";
}

// --------------------- PARSER ------------------------
/**
* the extension parser. it recognise the following structure
* and create an AST (Abstract Syntax Tree)
* <ul>
* <li> #define CONST INTVALUE
* <li> extern funcType funcName
* <li> typedef funcDeclaration
* </ul>
*
* @version 1.0
* @author Lloyd Dupont <a href=mailto:lloyd@galador.net>lloyd@galador.net</a>
*/
// note: I didn't use '^' because I didn't like the default root produced
class GLParser extends Parser;
options {
	k=2;
    buildAST = true;
    exportVocab = GLExt;
}
tokens {
    CONST_DEF; TYPE; FUNC_DEF; FUNC; PARAMS;
}

// this is stage 1 - syntax analysis
parse
	:	( line )*
	;

line
	:	const_def 
    |	func_def 
    |	func_decl
    ;

const_def!
	:	(DEFINE ID NUM) => DEFINE ID NUM
    		{ ## = #([CONST_DEF,"const"], ID, NUM); }
	|	DEFINE ID
    ;
    
// optional but better
func_decl 
	:	"extern"!
    		 ID // func type
             ID // func name 
             SEMI!
    { ## = #([FUNC, "function"], ##); }
    ;
    
func_def
	:	"typedef"!	
    		type 
            LPAR! "APIENTRY"! STAR! ID // func type name
            RPAR! args SEMI!
    { ## = #([FUNC_DEF, "proc def"], ##); }
    ;
    
args
	:!	LPAR RPAR
	|!	(LPAR VOID RPAR)=> LPAR VOID RPAR
    |	LPAR! argList RPAR!	{ ## = #([PARAMS, "args"], ##); }
    ;
    
argList
	:	type ID (COMMA! type ID) *
    ;
    
type
	:	("const"!)? (VOID|GLTYPE|ID) (STAR) *
    { ## = #([TYPE, "type"], ##); }
    ;

// --------------------------- LEXER -----------------------
/**
* the extension lexer. basically it recognise GL header token:<br>
* ID, NUMBER, "#define# '(' ')' ';' ','
*
* @author Lloyd Dupont <a href=mailto:lloyd@galador.net>lloyd@galador.net</a>
* @version 1.0
*/
class GLLexer extends Lexer;
options {
	k=4;
	charVocabulary  = '\3'..'\377';
	testLiterals=false;
}

WS	:	(' '
	|	'\t'
	|	'\n' {newline();}
	|	'\r')+
		{ $setType(Token.SKIP); }
	;
SL_COMMENT : 
	"//" 
	(~'\n')* '\n'
	{ $setType(Token.SKIP); newline(); }
	;
ML_COMMENT
	:	"/*"
		(	{ LA(2)!='/' }? '*'
		|	'\n' { newline(); }
		|	~('*'|'\n')
		)*
		"*/"
			{ $setType(Token.SKIP); }
	;

LPAR:	'(' ;
RPAR:	')' ;
COMMA:	',' ;
SEMI:	';' ;
STAR:	'*' ;

ID
	options { testLiterals=true; }
	:	('a'..'z'|'A'..'Z'|'_'|'$') ('a'..'z'|'A'..'Z'|'_'|'$'|'0'..'9')*
	;

PRECOMPILE_IGNORED
	:	("#endif" | "#ifndef" | "#ifdef" | "#include" | "#line") (~('\n')) *
		{ $setType(Token.SKIP); }
	;
DEFINE
	: "#define"
    ;
NUM
	: HEXANUM | INT
	;
protected HEXANUM
	: "0x" ('a'..'f'|'A'..'F'|'0'..'9') + 
    ;
protected INT
	: ('0'..'9') + 
    ;
STRING
	:	'"' (~('\n'|'"')) * '"'
	;
	
GLTYPE
	:	"GLenum"
    |	"GLbyte"
    |	"GLshort"
    |	"GLint"
    |	"GLsizei"
    |	"GLubyte"
    |	"GLuint"
    |	"GLfloat"
    |	"GLushort"
    |	("GLclampf")=>"GLclampf"
    |	"GLdouble"
    |	"GLclampd"
    |	"GLboolean"	
    |	"GLbitfield"
    ;
VOID
	:	"void" 
    |	"GLvoid"
    ;

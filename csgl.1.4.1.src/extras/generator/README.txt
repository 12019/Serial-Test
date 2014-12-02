This GLGenerator is BSD open source licenced.
-------------
Run it:
it depends on antlr.runtime.dll, so put them together.
call it like that
	generator myExtensionHeader.h

it will generate 2 files:
- extension.cs a class which enable to call you extension
- newCall.cs the list of function you should put in CFunction.cs 
(in CsGL code) for the extension to work. But these function could 
already exist. so:

ALSO put the csgl.dll in your working directory while generating your
extensions file.
generator.exe would look in it and genrate only the needed new call.


-------------
Build it:
to build it you will need:

- C# compiler
- java (for ANTLR) (http://java.sun.com)
- ANTLR (http://www.antlr.org)
- the C# runtime for ANTLR (separated file at this time)
- make (http://www.mingw.org)

It produce the file "generator.exe"
this executable read OpenGL extension header and produce an
OpenGL friendly extension class code in a file called "extension.cs"

it also provide the list of call to add in CsGL.Util.CFunction
in a file called "newCall.cs"

With version 1.0 it only support a limited syntax
(therefore you should simplify your header first)
it support:
	- comment
	- #define ACONT 0xAnHexaValue
	- typdef type (APIENTRY * FUNCTYPE)(.. func arg ...)
	- extern FUNCTYPE funcName

you run it like this
generator myExtensionHeaderFile

--
note: the ShowTree.java file is just here for debug/testing the parser
and you should change its target language (to java) for it to work...

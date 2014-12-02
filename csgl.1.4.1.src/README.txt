Authors : Lloyd Dupont (lloyd@galador.net)
Web: http://csgl.souceforge.net

it implements
-------------
 - all 1.4 OpenGL, GLU call
 - some GLUT call, some OpenGL extension
 - usefull init/rendering tool for OpenGL

 - you could also generate your extension file from the header
 from <csgl>/extras/generator/generator.exe
 
core files:
-----------
 - csgl.dll         the OpenGL API and some other tools. it's a .NET assembly
 - csgl.native.dll  this is a private native DLL to be used by csgl.dll to do non NET stuff
 
Runtime requirement:
--------------------
 - .NET Runtime
 - OpenGL : OpenGL library (must be shipped with windows or: http://www.opengl.org)


Compile time requirement:
-------------------------
 csgl.dll:
   - .NET SDK (csc) (clic on <csgl>/src/buidcs.bat)

 csgl.native.dll:
   - OpenGL header
   - UNIX find (on CsGL site or in mingw http://www.mingw.org)
   - GNUmakefile (mingw, cygwin ?)
   - gcc (in mingw => http://www.mingw.org)
 
 - to build simply type "make" (make lib or libinstall, as you want)


Data translation rules:
-----------------------
OpenGL API, a C API often take pointer type as parameter
in order to have so-called safe (without pointer) code
the following translation rules apply:
	type* -> type[]

2 problems remains though.
- the void* cannot be so translated
- sometimes OpenGL just retain the pointer address 
(glColorPointer(..), glSelectBuffer(..), ..) and managed array
could move.. 

to address this problem, first such function take a pointer 
argument (System.IntPtr) and second there is a class
CsGL.Pointers.PVoid which could alloc and return an unmoving pointer.
Though you generally use one of its childs CsGL.Pointers.PType, 
such as PFloat, PUInt32, etc... like this:
PUInt32 p = new PUInt32(N);
for(i=0; p.Length; i++)
	p[i] = whatever();
glSelectBuffer(p.Lenth /*N*/, p);

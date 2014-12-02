
all: 03.exe
03.exe: 03.cpp csgl.dll csgl.native.dll
	cl /nologo /DWIN32 /CLR /o $@ 03.cpp

run test check: all
	03

clean:
	-rm *.obj *.exe *.dll *.pdb *.ilk

csgl.dll csgl.native.dll:
	cp ../../lib/csgl*.dll .
	-cp ../../lib/csgl*.pdb .
	

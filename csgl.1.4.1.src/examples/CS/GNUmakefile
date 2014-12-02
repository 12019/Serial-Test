LIBS = csgl.dll csgl.native.dll

# ----------------------------
# standart rules and variables
# ----------------------------
LIB_DIR = ../../lib
#-----------------------------

all:  $(LIBS) drawimage.exe display.exe \
	palette.exe gdifont.exe quadric.exe \
	event.exe

%.exe: $(LIBS) %.cs
	csc /nologo /out:$@ /r:csgl.dll \
		$(OPTIONS) \
		$(@:.exe=.cs)
	
$(LIBS):
	cp $(LIB_DIR)/* .
clean:
	-rm *.exe *.dll *.pdb *.ilk 

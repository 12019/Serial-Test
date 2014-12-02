SYS_LIBS = /r:System.dll /r:System.Drawing.dll /r:System.Windows.Forms.dll
LIBS = csgl.dll csgl.native.dll

# ----------------------------
# standart rules and variables
# ----------------------------
LIB_DIR = ../../lib

#-----------------------------

all:  $(LIBS) simple.exe

simple.exe: $(LIBS) Simple.java GLModel.java View.java
	vjc /out:simple.exe /r:csgl.dll \
		$(SYS_LIBS) \
		$(OPTIONS) \
		Simple.java GLModel.java View.java

$(LIBS):
	cp $(LIB_DIR)/* .
clean:
	-rm *.exe *.dll *.pdb *.ilk 

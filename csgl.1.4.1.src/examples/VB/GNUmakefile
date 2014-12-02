FILES = MyForm.vb  GLView.vb  Model.vb
LIBS  = /r:System.dll /r:System.Drawing.dll /r:System.Windows.Forms.dll \
		/r:csgl.dll


all: vb.exe
run: all
	vb
	
vb.exe: $(FILES) csgl.dll
	vbc /out:vb.exe $(LIBS) $(FILES)
	
csgl.dll:
	cp ../../lib/csgl* .
clean:
	-rm *.exe *.dll *.pdb *.ilk 

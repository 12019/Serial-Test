ALLENTRY = doc examples extras lib libinstall src \
		GNUmakefile csgl_1.x.cmbx README.txt

####### VARIABLES ##########
PROJECT = csgl
VERSION = 1.4.1
ifeq '$(VERSION)' ''
	NAME = $(PROJECT)
else
	NAME = $(PROJECT).$(VERSION)
endif

TARGET ?= DEBUG
TOS    ?= WIN32
export TARGET
export TOS

.PHONY: doc lib libinstall clean veryclean

####### TARGETS ############

all: lib check
lib:
	cd src/Native/src && make
	cd src/CSharp     && make

libinstall: override TARGET=INSTALL
libinstall:
	cd src/Native/src && make
	cd src/CSharp     && make
	cp extras/install.bat libinstall
	cp extras/csgl.rsp    libinstall

install: 
	cd libinstall && install.bat
 
uninstall:
	cd extras && install.bat -u

test check:
	cd examples && make all
    
veryclean: clean
	-rm -rf lib/* libinstall/*
    
clean:
	cd src/Native/src && make clean
	cd src/CSharp     && make clean
	cd examples       && make clean

## -- archives --
dist: 
	make $(NAME).doc.zip
	make clean
	make binzip
	make veryclean $(NAME).src.zip
    
zip:
	tar czf csgl.tgz $(ALLENTRY)

# there is a clean in the middle to
# regenerate the OBJ file with the strong-key inside...
binzip: lib clean libinstall
	-rm $(NAME).dll.zip
	zip -9r $(NAME).dll.zip lib libinstall

$(NAME).src.zip: force
	-rm $(NAME).src.zip
	zip -9r $@ $(ALLENTRY)

$(NAME).src.bz2: force
	tar cjf $@ $(ALLENTRY)
	
$(NAME).src.tgz: force
	tar czf $@ $(ALLENTRY)

$(NAME).doc.zip: force
	-rm $(NAME).doc.zip
	cd devdoc && zip -9r ../$@ *

force: ;
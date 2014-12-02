SOURCES  = $(shell find . -name "*.cs")

####### VARIABLES ##########
TARGET ?= DEBUG
TOS    ?= WIN32
VPATH   = $(DST_DIR) .

####### CONFIGURATION ######
CSFLAGS = /o+ /d:STRONG
DST_DIR = ../../libinstall

ifeq "$(TARGET)" "DEBUG"
CSFLAGS = /debug
DST_DIR = ../../lib
endif

####### TARGETS ############
all: csgl.dll
csgl.dll: $(DST_DIR) csgl.snk $(SOURCES)
	csc /nologo /d:$(TOS) /unsafe $(CSFLAGS) /t:library \
		/out:$(DST_DIR)/$@ /recurse:*.cs

$(DST_DIR):
	mkdir -p $@

csgl.snk:
	sn -k csgl.snk

clean:

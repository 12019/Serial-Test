FILES = \
	csgl_sys \
	csgl_pointer \
	csgl_call \
	csgl_screen \
	csgl_opengl \
	csgl_palette \
	csgl_keyboard \
	csgl_mouse

OBJS = $(FILES:=.$(TOS).o)

####### VARIABLES ##########
TARGET ?= DEBUG
TOS    ?= WIN32
VPATH   = $(DST_DIR) .

####### CONFIGURATION ######
CC      = gcc
CFLAGS  = -Wall
LDFLAGS = 
DST_DIR = ../../../libinstall
LIB     = -lOPENGL32 -lgdi32

ifeq "$(TARGET)" "DEBUG"
DST_DIR = ../../../lib
endif

####### RULES ##############
%.$(TOS).o : %.$(TOS).c
	$(CC) -c -o $@ $(CFLAGS) -I ../include $^
	
%.$(TOS).o : %.c
	$(CC) -c -o $@ $(CFLAGS) -I ../include $^

####### TARGETS ############

all: $(DST_DIR) csgl.native.dll

$(DST_DIR):
	mkdir -p $@

csgl.native.dll: $(OBJS)
	gcc -shared -o $@ $^ $(LIB)
	strip $@
	mv $@ $(DST_DIR)
    
clean:
	-rm -f *.o *.dll

/*
 * BSD Licence:
 * Copyright (c) 2001, Lloyd Dupont (lloyd@galador.net)
 * <ORGANIZATION> 
 * All rights reserved.
 * 
 *
 * Redistribution and use in source and binary forms, with or without 
 * modification, are permitted provided that the following conditions are met:
 *
 * 1. Redistributions of source code must retain the above copyright notice, 
 * this list of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright 
 * notice, this list of conditions and the following disclaimer in the 
 * documentation and/or other materials provided with the distribution.
 * 3. Neither the name of the <ORGANIZATION> nor the names of its contributors
 * may be used to endorse or promote products derived from this software
 * without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE REGENTS OR CONTRIBUTORS BE LIABLE FOR
 * ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 
 * LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
 * OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH
 * DAMAGE.
 */
#include "csgl_palette.h"
#include "csgl_sys.h"
#include <windows.h>

//------------- CAUTION ---------------
// This is actually unworking code
// let there for future generation 
// (and beyond) to remember...
// who knows it could work on FreeBSD ?
// these are just guidelines
//-------------------------------------
struct internalPalette
{
	LOGPALETTE* colors;
	HPALETTE wpal, oldpal;
};

CSGLPalette* csgl_palette_createPalette(CsglPixel* fmt, void* gdi, int32_t* palSize)
{
	CSGLPalette* ret;
	int size, maxColors;
	WORD nColors;

	maxColors = GetDeviceCaps((HDC)gdi, SIZEPALETTE);
	if(maxColors<1)
		return NULL;
		
	nColors = 1 << (fmt->cColorBits-1);
	if(nColors>maxColors)
		nColors = maxColors;
	*palSize = nColors;
	
	size = sizeof(CSGLPalette) + sizeof(LOGPALETTE) + nColors * sizeof(PALETTEENTRY);
	ret = malloc(size);
	if(ret==NULL) 
		csgl_assert_throw("not enough memory");
	memset(ret, 0, size);
	
	ret->colors = (LOGPALETTE*) (ret+1);
	ret->colors->palVersion = 0x300;
	ret->colors->palNumEntries = nColors;

	ret->wpal = CreatePalette(ret->colors);
	if(ret->wpal==NULL) {
		free(ret);
		csgl_assert_throw("can't create palette");
	}
	
	ret->oldpal = SelectPalette((HDC)gdi, ret->wpal, FALSE);
	if(ret->oldpal==NULL) {
		DeleteObject(ret->wpal);
		free(ret);
		csgl_assert_throw("can't set the device palette");
	}
	
	// init the palette with the system entries...
	// don't bother about errors
	//GetPaletteEntries(ret->oldpal, 0, nColors, ret->colors->palPalEntry);
	csgl_sys_setLastError(NO_ERROR); // don't bother, really ..
	                  
	RealizePalette((HDC) gdi);
	csgl_assert();
	
	return ret;
}
void csgl_palette_destroyPalette(CSGLPalette* pal, void* gdi)
{
	if(pal==NULL)
		return;
	
	if(gdi && !SelectPalette((HDC)gdi, pal->oldpal, TRUE)) {
		// uh... what could I do ?
		// pretend it's ok...
		DPRINT(can'\''t free palette);
	}
	
	DeleteObject(pal->wpal);
	free(pal);
}
void csgl_palette_color(CSGLPalette* pal, int32_t get, int32_t index, uint8_t* r, uint8_t* g, uint8_t* b)
{
	PALETTEENTRY* pe = pal->colors->palPalEntry + index;
	if(get) {
		*r = pe->peRed;
		*g = pe->peGreen;
		*b = pe->peBlue;
	}
	else {
		pe->peRed   = *r;
		pe->peGreen = *g;
		pe->peBlue  = *b;
	}
}
void csgl_palette_update(CSGLPalette* pal, void* gdi)
{
	SetPaletteEntries(pal->wpal, 0, pal->colors->palNumEntries, pal->colors->palPalEntry);
	if(RealizePalette((HDC) gdi) == GDI_ERROR)
		csgl_assert_throw("error updating palette");
}

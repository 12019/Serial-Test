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
#include "csgl_screen.h"
#include "csgl_sys.h"
#include <windows.h>

static void initDEVMODE(DEVMODE * dev)
{
	memset(dev, 0, sizeof(DEVMODE));
	dev->dmSize = sizeof(DEVMODE);
}

int32_t csgl_screen_countDisplay()
{
	int32_t mode = 0;
	DEVMODE scrSettings;
	initDEVMODE(&scrSettings);

	while(EnumDisplaySettings(NULL, mode ++, &scrSettings));
	return mode-1;
}

void csgl_screen_getDisplay(int32_t index, int32_t* w, int32_t* h, int32_t* c)
{
	DEVMODE scrSettings;
	initDEVMODE(&scrSettings);

    if(index == -1)
    	index = ENUM_CURRENT_SETTINGS;
        
	if(! EnumDisplaySettings(NULL, index, &scrSettings))
    	csgl_assert_throw_format("Unknow error while getting DisplayMode %d", index);
        
	*w = scrSettings.dmPelsWidth;
	*h = scrSettings.dmPelsHeight;
	*c = scrSettings.dmBitsPerPel;
}

int32_t csgl_screen_isCompatibleDisplay(int32_t index)
{
	DEVMODE current, aMode;
	initDEVMODE(&current);
	initDEVMODE(&aMode);
    
	EnumDisplaySettings(NULL, ENUM_CURRENT_SETTINGS, &current);
	EnumDisplaySettings(NULL, index, &aMode);

	if(aMode.dmBitsPerPel == current.dmBitsPerPel
		&& aMode.dmDisplayFrequency == current.dmDisplayFrequency
		&& aMode.dmDisplayFlags == current.dmDisplayFlags)
        return 1;
    return 0;
}

void csgl_screen_setDisplay(int32_t w, int32_t h, int32_t c)
{
	DEVMODE display; // Device Mode
    
    if(!w || !h || !c) // reset to original mode
    {
		ChangeDisplaySettings(NULL,0);
        return;
	}
    
	memset(&display, 0, sizeof(DEVMODE));
	display.dmSize       = sizeof(DEVMODE);
	display.dmPelsWidth  = w;
	display.dmPelsHeight = h;
	display.dmBitsPerPel = c;
	display.dmFields     = DM_PELSWIDTH|DM_PELSHEIGHT|DM_BITSPERPEL;
    
		
	// Try To Set Selected Mode And Get Results.  NOTE: CDS_FULLSCREEN Gets Rid Of Start Bar.
	switch(ChangeDisplaySettings(&display, CDS_FULLSCREEN))
	{
		case DISP_CHANGE_SUCCESSFUL:
			break; // ok
		default:
			csgl_assert_throw("Resolution change didn't work");
	}
}

@ if "%1" == ""        goto usage
@ if not exist "%1.cs" goto usage
@ goto runex

:usage
@ echo "usage:"
@ echo " run example (withouth .cs or .exe), ex: run quadric"
@ pause
@ goto end

:runex
csc /nologo /out:%1.exe /r:csgl.dll %1.cs
%1
@goto end

:end

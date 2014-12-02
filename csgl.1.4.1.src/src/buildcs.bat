@ if /I "%1" == "install" goto install_build

:install
csc /nologo /d:WIN32 /unsafe /debug /t:library /out:../lib/csgl.dll /recurse:*.cs

@ goto end
:install_build
csc /nologo /d:WIN32 /unsafe /o+ /d:STRONG /t:library /out:../libinstall/csgl.dll /recurse:*.cs

:end
pause
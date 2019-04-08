@echo off
::Must have for loop to work
setlocal EnableDelayedExpansion 

color f9
ECHO.Insira o numero do laboratorio
SET /P labNumber=
ECHO.Insira o numero de computadores
SET /P computerNumber=

Xcopy %~dp0PsExec64.exe c:\Windows\System32 /q /y
FOR /l %%G IN (1, 1, !computerNumber!) DO ( 
ping -n 1 -w 1000 10.54.!labNumber!.%%G > nul
	IF !errorlevel! EQU 0 (
		ECHO.copying to machine %%G.
		Xcopy %~dp0auto_logon.reg \\10.54.!labNumber!.%%G\c$\Users\manutencaofa7\Desktop\ /c /s /e /h /q /y
		psexec64.exe \\10.54.!labNumber!.%%G -u 7SETLABS\manutencaofa7 -p shift1dois3 -h -d -i cmd /K "regedit.exe /S c:\Users\manutencaofa7\Desktop\auto_logon.reg"
		shutdown /r /f /t 000 /m \\10.54.!labNumber!.%%G
	) ELSE (
		ECHO.mic %%G Nao encontrado, cheque a conexao.
	)
)
PAUSE
exit
@echo on

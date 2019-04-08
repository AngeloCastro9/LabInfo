@echo off
:: Must have for loop to work
setlocal EnableDelayedExpansion
color f9
ECHO.Insira o numero do laboratorio
SET /P labNumber=
ECHO.Insira o numero de computadores 
SET /P computerNumber=

FOR /l %%G IN (1, 1, !computerNumber!) DO ( 
ping -n 1 -w 1000 10.54.!labNumber!.%%G > nul
	IF !errorlevel! EQU 0 (
		PsExec64.exe \\10.54.!labNumber!.%%G -u 7SETLABS\manutencaofa7 -p shift1dois3 -h -d -i "C:\Program Files\Adobe\Adobe Animate CC 2018/Animate.exe"
	) ELSE (
		ECHO.mic %%G Nao encontrado. Cheque a conexao!!!
	)
)
:goto :start
PAUSE
exit
@echo on
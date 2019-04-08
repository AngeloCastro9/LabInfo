@echo off
::Must have for loop to work
setlocal EnableDelayedExpansion 

color f9
ECHO.Insira o numero do laboratorio
SET /P labNumber=
ECHO.Insira o numero de computadores
SET /P computerNumber=
ECHO. Insira o caminho da pasta ou o nome do arquivo
SET /P source=
ECHO.Insira o destino do arquivo(obs: mude c: para c$, ou isso nao vai funcionar.)
set /P destination=

FOR /l %%G IN (1, 1, !computerNumber!) DO ( 
ping -n 1 -w 1000 10.54.!labNumber!.%%G > nul
	IF !errorlevel! EQU 0 (
		ECHO.copying to machine %%G.
		Xcopy !source! \\10.54.!labNumber!.%%G\!destination! /c /s /e /h /q /y  
	) ELSE (
		ECHO.mic %%G Não encontrado na rede.
	)
)
PAUSE
exit
@echo on
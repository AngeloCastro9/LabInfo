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
		ECHO.micro %%G encontrado na rede.s
	) ELSE (
		ECHO.micro %%G não encontrado.
	)
)
PAUSE
exit
@echo on
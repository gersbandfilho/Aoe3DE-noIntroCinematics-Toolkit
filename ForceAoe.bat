@echo off
color F0
set app=AoE3DE_s.exe
set folder_app=S:\SteamLibrary\steamapps\common\AoE3DE

taskkill /F /T /IM %app% >nul 2>&1

if %errorlevel%==0 (
    echo Processo %app% finalizado com sucesso.
    echo Solicitando reinicio.
) else (
    echo Nao foi possivel finalizar %app% ou ele nao estava em execucao.
    echo Solicitando início.
)

timeout /t 1 /nobreak >nul

echo Aguardando Steam...

timeout /t 2 /nobreak >nul

echo Reiniciando %app%...

timeout /t 3 /nobreak >nul

if exist "%folder_app%\%app%" (
    cd /d "%folder_app%"
    start "" "%app%"
    echo Processo %app% iniciado com sucesso.
) else (
    echo [ERRO] Nao foi possivel iniciar ou encontrar %app% na pasta indicada.
)

timeout /t 6 /nobreak >nul

exit
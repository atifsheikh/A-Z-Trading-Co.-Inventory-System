@echo off
staradmin kill all

REM Start Launcher
cd E:\Development\Orator\Developmentcodes\adfenix-backend\Launcher
call run.bat

REM Start Sign-In 
cd E:\Development\Orator\Developmentcodes\adfenix-backend\UserAdminApp
call run.bat

REM Start Sign-In 
cd E:\Development\Orator\Developmentcodes\adfenix-backend\SignInApp
call run.bat

REM AdFenix
cd E:\Development\Orator\Developmentcodes\adfenix-backend
call run.bat


pause
@echo off
dbl -XT test
dblink test
del /q *.dbo
dbr test
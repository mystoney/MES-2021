@echo off 
@title 安装windows服务
@echo off 
echo= 安装服务!
@echo off  
@sc create MES_WorkerService_GetOrder binPath= "%~dp0MES.WorkerService.exe"  
echo= 启动服务!
@echo off  
@sc start MES_WorkerService_GetOrder 
@echo off  
echo= 配置服务! 
@echo off  
@sc config MES_WorkerService_GetOrder start= AUTO  
@echo off  
echo= 成功安装、启动、配置服务!   
@pause
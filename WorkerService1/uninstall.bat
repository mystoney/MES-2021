@echo off 
@title 卸载windows服务
@echo off 
echo= 停止服务!
@echo off  
@sc stop MES_WorkerService_GetOrder
echo= 卸载服务!
@echo off  
@sc delete MES_WorkerService_GetOrder
@echo off  
echo= 成功停止、卸载服务!   
@pause
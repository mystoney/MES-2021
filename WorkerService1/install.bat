@echo off 
@title ��װwindows����
@echo off 
echo= ��װ����!
@echo off  
@sc create MES_WorkerService_GetOrder binPath= "%~dp0MES.WorkerService.exe"  
echo= ��������!
@echo off  
@sc start MES_WorkerService_GetOrder 
@echo off  
echo= ���÷���! 
@echo off  
@sc config MES_WorkerService_GetOrder start= AUTO  
@echo off  
echo= �ɹ���װ�����������÷���!   
@pause
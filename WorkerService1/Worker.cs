using MES.module.BLL;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Helper_Core;

namespace WorkerService1
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                GetOrder();
                Console.WriteLine("Hello world!!");
                await Task.Delay(60000000, stoppingToken);

            }
        }

        private void GetOrder()
        {

            OrderBll.Return_Message rm_Order = new OrderBll.Return_Message();
            DateString ds = new DateString();
            ds.beginDate = DateTime.Parse(DateTime.Now.AddDays(-30).ToShortDateString());
            ds.endDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            //string getordermodel = $@" http://172.16.1.16:9999/api/GetJobNumFromDate?DS={ Helper.Json.JsonHelper.SerializeObject( ds )}";
            string getordermodel = $@" http://172.16.1.16:9999/api/GetJobNumFromDate?DS={ ds.ConvertToJson() }";          
            
            
            //rm_Order = Helper.Json.JsonHelper.DeserializeJsonToObject<OrderBll.Return_Message>(Helper.Http.Http.HttpGet(getordermodel));
            rm_Order = Helper_Core.Http.Http.HttpGet(getordermodel).ConvertToObject<OrderBll.Return_Message>();

            if (rm_Order.State == OrderBll.Return_Message.Return_State.Error)
            {
                throw new Exception(rm_Order.Message);
            }

            //DataTable dt = Helper.Json.JsonHelper.DeserializeJsonToObject<DataTable>(rm_Order.Return_Value);

            DataTable dt = rm_Order.Return_Value.ConvertToObject<DataTable>();

            OrderBll ob = new OrderBll();
            int a = ob.SaveOrderZYQ(dt);//调用ZYQ接口，获取到所有工单
            if (a == 1)
            {
                ob.InsertOrderMaster();//将获取到的工单信息保存到MES_ORDER_MASTER,如果款号已维护，同时保存选项
            }
            ob.SaveOrderOpListNo();//将所有未锁定的订单中，有工单选项，没有工序清单的自动绑定工序清单

            ob.SaveProductListAll();

        }

        private class DateString
        {
            public DateTime beginDate { get; set; }
            public DateTime endDate { get; set; }
        }


    }
}


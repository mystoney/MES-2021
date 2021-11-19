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

namespace MES.WorkerService
{
    public class GetOrder : BackgroundService
    {
        private readonly ILogger<GetOrder> _logger;

        public GetOrder(ILogger<GetOrder> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                 _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                string urlstring = "http://172.16.1.37:57722/api/GetOrder";
                Helper_Core.Http.Http.HttpGet(urlstring);
                Console.WriteLine("Íê³É!!");
                int hours = 3*60*60*1000;
                await Task.Delay(hours, stoppingToken);            }
        }



    }
}


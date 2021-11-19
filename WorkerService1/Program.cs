using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MES.WorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<GetOrder>();
                });
        //public static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    return Host.CreateDefaultBuilder(args)//使用默认配置实例化Host主机                      
        //        .UseWindowsService()//指定项目可以部署为Windows服务
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>()
        //            .UseKestrel(options =>
        //            {
        //                options.Listen(IPAddress.Any, 50003);//指定端口号，不然如果部署了多个服务，容易出现端口号占用
        //                options.Limits.MaxRequestBodySize = null;
        //            }); ;
        //        })
        //        .UseDefaultServiceProvider(options => options.ValidateScopes = false);
        //}
    }
}

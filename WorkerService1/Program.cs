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
        //    return Host.CreateDefaultBuilder(args)//ʹ��Ĭ������ʵ����Host����                      
        //        .UseWindowsService()//ָ����Ŀ���Բ���ΪWindows����
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>()
        //            .UseKestrel(options =>
        //            {
        //                options.Listen(IPAddress.Any, 50003);//ָ���˿ںţ���Ȼ��������˶���������׳��ֶ˿ں�ռ��
        //                options.Limits.MaxRequestBodySize = null;
        //            }); ;
        //        })
        //        .UseDefaultServiceProvider(options => options.ValidateScopes = false);
        //}
    }
}

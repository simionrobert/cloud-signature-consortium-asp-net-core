using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Ocelot.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();

                    webBuilder.ConfigureAppConfiguration((hostingContext, config) => {
                        config
                            .AddJsonFile($"ocelot.json", optional: false, reloadOnChange: true)
                            .AddJsonFile($"ocelot.csc.json", optional: false, reloadOnChange: true)
                            .AddJsonFile($"ocelot.oauth.json", optional: false, reloadOnChange: true);

                        config.AddOcelot(hostingContext.HostingEnvironment);
                    });
                })
            .ConfigureLogging(logging => logging.AddConsole());
    }
}

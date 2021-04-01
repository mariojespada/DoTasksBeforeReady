using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StarwarsTheme.PriorToReadyTasks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StarwarsTheme
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            await ExecutePriorToReadyTask(host, CancellationToken.None);
            await host.RunAsync(CancellationToken.None);
        }

        private async static Task ExecutePriorToReadyTask(IHost host, CancellationToken cancellationToken)
        {
            //This is a collection, so if you have to execute many tasks before startup you can
            var startupTaskCollection = host.Services.GetServices<IStartupTask>();
            // Execute all the tasks
            foreach (var startupTask in startupTaskCollection)
            {
                await startupTask.ExecuteAsync(cancellationToken);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


    }
}

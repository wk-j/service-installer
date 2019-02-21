using System;
using ConsoleService;
using System.Linq;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace ConsoleApp {
    class Program {
        static async System.Threading.Tasks.Task Main(string[] args) {
            var isService = !(Debugger.IsAttached || args.Contains("--console"));
            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) => {
                    services.AddHostedService<ConsoleService.BackgroundService>();
                });

            if (isService) {
                await builder.RunAsServiceAsync();
            } else {
                await builder.RunConsoleAsync();
            }
        }
    }
}

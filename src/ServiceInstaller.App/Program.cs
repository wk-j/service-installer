using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ConsoleService;

namespace ServiceInstaller.App {

    class Program {

        static async Task Main(string[] args) {
            await new HostBuilder()
                .ConfigureServices((hostContext, services) => {
                    services.AddHostedService<ConsoleService.ConsoleService>();
                })
            .RunConsoleAsync();
        }
    }
}

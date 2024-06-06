using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StockPro.Application.IoC;
using StockPro.Infrasctructure.IoC;
using StockPro.Presentation.Forms.Customer;
using StockPro.Presentation.Forms.IoC;

namespace StockPro.Presentation
{
    internal static class Program
    {        
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            ApplicationConfiguration.Initialize();

            System.Windows.Forms.
                Application.Run(host.Services.GetRequiredService<FrmCustomer>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(AppDomain.CurrentDomain.BaseDirectory);
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddApplicationModules();
                    services.AddInfraModules();
                    services.AddFormsModule();
                });
        }
    }
}
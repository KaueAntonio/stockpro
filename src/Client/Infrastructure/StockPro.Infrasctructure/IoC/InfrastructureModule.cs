using Microsoft.Extensions.DependencyInjection;
using StockPro.Infrasctructure.Data;
using StockPro.Infrasctructure.Data.Interfaces;

namespace StockPro.Infrasctructure.IoC
{
    public static class InfrastructureModule
    {
        public static void AddInfraModules(this IServiceCollection services)
        {
            services.AddSingleton<IConnection, Connection>();
        }
    }
}

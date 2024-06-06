using Microsoft.Extensions.DependencyInjection;
using StockPro.Application.V1.Customer.Interfaces.Repositories;
using StockPro.Application.V1.Customer.Repositories;
using StockPro.Application.V1.Customer.Services;
using StockPro.Application.V1.Customer.Interfaces.Services;

namespace StockPro.Application.IoC
{
    public static class ApplicationModules
    {
        public static void AddApplicationModules(this IServiceCollection services)
        {
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
            services.AddSingleton<ICustomerService, CustomerService>();
        }
    }
}

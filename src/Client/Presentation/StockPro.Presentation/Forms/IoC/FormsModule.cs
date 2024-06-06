using Microsoft.Extensions.DependencyInjection;
using StockPro.Presentation.Forms.Customer;

namespace StockPro.Presentation.Forms.IoC
{
    internal static class FormsModule
    {
        public static void AddFormsModule(this IServiceCollection services)
        {
            services.AddSingleton<FrmCustomer>();
        }
    }
}

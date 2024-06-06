using StockPro.Application.V1.Customer.Models.Input;
using StockPro.Application.V1.Customer.Models.Output;

namespace StockPro.Application.V1.Customer.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task Create(InCustomer customer);
        Task<IEnumerable<OutCustomer>> GetByFilter(string filter, string value);
    }
}

using StockPro.Application.V1.Customer.Interfaces.Repositories;
using StockPro.Application.V1.Customer.Interfaces.Services;
using StockPro.Application.V1.Customer.Models.Input;
using StockPro.Application.V1.Customer.Models.Output;

namespace StockPro.Application.V1.Customer.Services
{
    public class CustomerService(ICustomerRepository customerRepository) : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository = customerRepository;
        public async Task Create(InCustomer customer)
        {
            await _customerRepository.Create(customer);
        }

        public async Task<IEnumerable<OutCustomer>> GetByFilter(string filter, string value)
        {
            var result = await _customerRepository.GetByFilter(filter, value);

            return result;
        }
    }
}

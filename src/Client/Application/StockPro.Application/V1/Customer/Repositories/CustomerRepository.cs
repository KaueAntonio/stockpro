using Dapper;
using System.Data;
using StockPro.Application.V1.Customer.Models.Input;
using StockPro.Application.V1.Customer.Interfaces.Repositories;
using StockPro.Infrasctructure.Data.Interfaces;
using StockPro.Application.V1.Customer.Models.Output;

namespace StockPro.Application.V1.Customer.Repositories
{
    public class CustomerRepository(IConnection connection) : ICustomerRepository
    {
        private readonly IConnection _connection = connection;

        public async Task Create(InCustomer customer)
        {
            using var connection = _connection.GetConnection();

            await connection.ExecuteAsync(
                sql: @"",
                param: customer,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<OutCustomer>> GetByFilter(string filter, string value)
        {
            using var connection = _connection.GetConnection();

            var result = await connection.QueryAsync<OutCustomer>(
                sql: @"",
                param: new { Filter = filter, 
                             Value  = value },
                commandType: CommandType.StoredProcedure);

            return result;
        }
    }
}

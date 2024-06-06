using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StockPro.Infrasctructure.Data.Interfaces;
using System.Data;

namespace StockPro.Infrasctructure.Data
{
    public class Connection(IConfiguration configuration) : IConnection
    {
        private readonly IConfiguration _configuration = configuration;
        public IDbConnection GetConnection()
        {
            string connectionString = _configuration.GetConnectionString("Database");

            return new SqlConnection(connectionString);
        }
    }
}

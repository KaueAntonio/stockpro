using System.Data;

namespace StockPro.Infrasctructure.Data.Interfaces
{
    public interface IConnection
    {
        IDbConnection GetConnection();
    }
}

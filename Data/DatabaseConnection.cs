using System.Data;
using MySql.Data.MySqlClient;

namespace csharp_grpc_cars.Data;
public class DatabaseConnection
{
    private readonly string _connectionString;
    public DatabaseConnection(string connectionString)
    {
        _connectionString = connectionString;
    }
    public IDbConnection CreateConnection()
    {
        return new MySqlConnection(_connectionString);
    }
}
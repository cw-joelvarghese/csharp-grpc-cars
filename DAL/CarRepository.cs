using System.Data;
using Dapper;
using csharp_grpc_cars.Models;
using MySql.Data.MySqlClient;

namespace csharp_grpc_cars.DAL;

public class CarRepository
{
    private readonly string _connectionString;

    public CarRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<CarResponseModel> GetPersonByIdAsync(int id)
        {
            using (IDbConnection dbConnection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT Id, Name, Email FROM Persons WHERE Id = @Id";
                return await dbConnection.QuerySingleOrDefaultAsync<CarResponseModel>(query, new { Id = id });
            }
        }
}
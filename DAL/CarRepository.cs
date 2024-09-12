using System.Data;
using Dapper;
using csharp_grpc_cars.Models;
using csharp_grpc_cars.Data;

namespace csharp_grpc_cars.DAL;

public class CarRepository
{
    private readonly IDbConnection _dbConnection;
    public CarRepository(DatabaseConnection databaseConnection)
    {
        _dbConnection = databaseConnection.CreateConnection();
    }

    public async Task<IEnumerable<CarModel>> GetCarsByIdAsync(List<int> ids)
    {
        string query = "SELECT * FROM stock WHERE Id IN @Ids";
        return await _dbConnection.QueryAsync<CarModel>(query, new { Ids = ids });
    }
}
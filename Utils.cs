using csharp_grpc_cars.Models;

public static class Utils
{
    public static bool IsValueForMoney(CarModel carModel)
    {
        return carModel.Price <= 200000 && carModel.Km < 10000;
    }
}
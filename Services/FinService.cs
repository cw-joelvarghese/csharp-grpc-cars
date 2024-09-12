using Grpc.Core;
using csharp_grpc_cars.BAL;

namespace csharp_grpc_cars.Services;

public class FinService : FinanceService.FinanceServiceBase
{
    private readonly ILogger<FinService> _logger;
    private readonly CarService _carService;
    public FinService(ILogger<FinService> logger, CarService carService) 
    {
        _logger = logger;
        _carService = carService;
    }

    public override async Task<CarsResponse> GetIsValueForMoney(CarsRequest request, ServerCallContext context)
    {
        return await _carService.GetCarsById(request);   
    }
}

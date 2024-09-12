using AutoMapper;
using csharp_grpc_cars.DAL;

namespace csharp_grpc_cars.BAL;

public class CarService
{
    private readonly CarRepository _carRepository;
    private readonly IMapper _mapper;
    public CarService (CarRepository carRepository, IMapper mapper) {
        _carRepository = carRepository;
        _mapper = mapper;
    }
    public async Task<CarsResponse> GetCarsById(CarsRequest request) {
        var cars = await _carRepository.GetCarsByIdAsync(request.Id.ToList());
        var mappedCars = _mapper.Map<List<CarStatus>>(cars);
        var carsResponse = new CarsResponse();
        carsResponse.Cars.AddRange(mappedCars);
        return carsResponse;
    }
}
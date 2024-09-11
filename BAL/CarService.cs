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
}
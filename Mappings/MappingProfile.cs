using AutoMapper;
using csharp_grpc_cars.Models;

namespace csharp_grpc_cars.Mappings;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CarModel, CarStatus>()
              .ForMember(dest => dest.IsValueForMoney, opt => opt.MapFrom(src =>
                  Utils.IsValueForMoney(src)))
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
    }
}
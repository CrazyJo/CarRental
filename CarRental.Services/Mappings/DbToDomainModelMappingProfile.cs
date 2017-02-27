using AutoMapper;
using CarRental.Data;
using CarRental.Services.Entities;

namespace CarRental.Services.Mappings
{
    public class DbToDomainModelMappingProfile : Profile
    {
        public DbToDomainModelMappingProfile()
        {
            CreateMap<AuthInfo, User>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Person.FirsName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Person.LastName));

            CreateMap<Car, CarInfo>()
                .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.ParkingItem.Balance))
                .ForMember(dest => dest.TotalCars, opt => opt.MapFrom(src => src.ParkingItem.TotalCars))
                .ForMember(dest => dest.PricePerHour, opt => opt.MapFrom(src => src.PriceItem.PricePerHour))
                .ForMember(dest => dest.Car,
                    opt => opt.MapFrom(src => new CarDto { Color = src.Color, Id = src.Id, Name = src.Name }));
        }
    }
}

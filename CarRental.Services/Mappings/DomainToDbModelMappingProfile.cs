using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CarRental.Data;
using CarRental.Services.Entities;

namespace CarRental.Services.Mappings
{
    public class DomainToDbModelMappingProfile : Profile
    {
        public DomainToDbModelMappingProfile()
        {
            CreateMap<CarInfo, Car>()
                .ForMember(dest => dest.CarDetail, opt => opt.ResolveUsing(Converter))
                .ForMember(dest => dest.ParkingItem, opt => opt.MapFrom(src => new ParkingItem { Balance = src.Balance, TotalCars = src.TotalCars }))
                .ForMember(dest => dest.PriceItem, opt => opt.MapFrom(src => new PriceItem { PricePerHour = src.PricePerHour }))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Car.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Car.Name));

            CreateMap<User, Person>()
                .ForMember(dest => dest.AuthInfo,
                opt => opt.MapFrom(src => new AuthInfo { UserName = src.UserName, Password = src.Password, Role = src.Role }));
        }

        private static object Converter(CarInfo src)
        {
            return new CarDetail {Color = src.Car.Color};
        }
    }
}
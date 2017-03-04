using System;
using AutoMapper;
using CarRental.Services.Entities;
using CarRental.View.Model;

namespace CarRental.View.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<CarInfo, CarInfoViewModel>()
                .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Car.Name))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Car.Id))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Car.Color));

            CreateMap<OrderDto, OrderViewModel>()
                .ForMember(dest => dest.CarId, opt => opt.MapFrom(src => src.Car.Id))
                .ForMember(dest => dest.Rest, opt => opt.MapFrom(src => (src.RentalDate + src.Lease).Subtract(DateTime.Now)))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Customer.Id))
                .ForMember(dest => dest.CarModel, opt => opt.MapFrom(src => src.Car.Name));

            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.UserName));
        }
    }
}
﻿using AutoMapper;
using CarRental.Data;
using CarRental.Services.Entities;

namespace CarRental.Services.Mappings
{
    public class DomainToDbModelMappingProfile : Profile
    {
        public DomainToDbModelMappingProfile()
        {
            CreateMap<OrderDto, Order>()
                .ForMember(dest => dest.DateRental, opt => opt.MapFrom(src => src.RentalDate))
                .ForMember(dest => dest.CarId, opt => opt.MapFrom(src => src.Car.Id))
                .ForMember(dest => dest.Car, opt => opt.Ignore())
                .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.Customer.Id))
                .ForMember(dest => dest.Lease, opt => opt.MapFrom(src => src.Lease));

            CreateMap<CarInfo, Car>()
                .ForMember(dest => dest.ParkingItem, opt => opt.MapFrom(src => new ParkingItem { Id = src.Car.Id, CarId = src.Car.Id, Balance = src.Balance, TotalCars = src.TotalCars }))
                .ForMember(dest => dest.PriceItem, opt => opt.MapFrom(src => new PriceItem { Id = src.Car.Id, CarId = src.Car.Id, PricePerHour = src.PricePerHour }))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Car.Id))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Car.Color))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Car.Name));

            CreateMap<User, Person>()
                .ForMember(dest => dest.AuthInfo,
                opt => opt.MapFrom(src => new AuthInfo { UserName = src.UserName, Password = src.Password, Role = src.Role }));
        }
    }
}
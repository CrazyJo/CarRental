using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                .ForMember(dest => dest.Roles, opt => opt.MapFrom(src => src.Role))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Person.FirsName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Person.LastName));
        }
    }
}

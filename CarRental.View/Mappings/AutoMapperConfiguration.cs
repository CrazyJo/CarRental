using AutoMapper;
using CarRental.Services.Mappings;

namespace CarRental.View.Mappings
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
                cfg.AddProfile<DomainToViewModelMappingProfile>();
                cfg.AddProfile<DomainToDbModelMappingProfile>();
                cfg.AddProfile<DbToDomainModelMappingProfile>();
            });
        }
    }
}

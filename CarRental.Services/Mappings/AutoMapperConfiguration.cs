using AutoMapper;

namespace CarRental.Services.Mappings
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DomainToDbModelMappingProfile>();
            });
        }
    }
}

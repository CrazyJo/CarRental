using CarRental.Data;
using CarRental.Services.Mappings;

namespace CarRental.Services
{
    public static class ServiceLayerConfig
    {
        public static void Configure()
        {
            AutoMapperConfiguration.Configure();
            DataLayerConfig.Configure();
        }
    }
}

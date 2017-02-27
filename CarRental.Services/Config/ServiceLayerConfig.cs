using CarRental.Data;
using CarRental.Services.Mappings;

namespace CarRental.Services.Config
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

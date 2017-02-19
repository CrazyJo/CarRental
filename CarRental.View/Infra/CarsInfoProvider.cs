using System.Collections.Generic;
using System.Windows.Forms;
using AutoMapper;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.View.Model;

namespace CarRental.View.Infra
{
    public class CarsInfoProvider : GridValueProvider<CarInfo, CarInfoViewModel>
    {
        public CarService CarService { get; set; }

        public CarsInfoProvider(CarService carService, DataGridView dataGridView) : base(dataGridView)
        {
            CarService = carService;
        }

        protected override IEnumerable<CarInfoViewModel> Convert(IEnumerable<CarInfo> domainModel)
        {
            return Mapper.Map<IEnumerable<CarInfoViewModel>>(domainModel);
        }

        protected override IEnumerable<CarInfo> GetDomainModel()
        {
            return CarService.GetCarsInfo();
        }
    }
}

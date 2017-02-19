using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AutoMapper;
using CarRental.Services.Entities;
using CarRental.View.Model;

namespace CarRental.View.Infra
{
    public class CarsInfoProvider : GridValueProvider<CarInfo, CarInfoViewModel>
    {
        public Func<IEnumerable<CarInfo>> CarFactory { get; set; }

        public CarsInfoProvider(Func<IEnumerable<CarInfo>> carFactory, DataGridView dataGridView) : base(dataGridView)
        {
            CarFactory = carFactory;
        }

        protected override IEnumerable<CarInfoViewModel> Convert(IEnumerable<CarInfo> domainModel)
        {
            return Mapper.Map<IEnumerable<CarInfoViewModel>>(domainModel);
        }

        protected override IEnumerable<CarInfo> GetDomainModel()
        {
            return CarFactory();
        }
    }
}

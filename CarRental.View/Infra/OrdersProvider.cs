using System.Collections.Generic;
using System.Windows.Forms;
using AutoMapper;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.View.Model;

namespace CarRental.View.Infra
{
    public class OrdersProvider : GridValueProvider<Order, OrderViewModel>
    {
        public IRentalService RentalService { get; set; }
        public User User { get; set; }

        public OrdersProvider(User user, IRentalService rentalService, DataGridView dataGridView) : base(dataGridView)
        {
            User = user;
            RentalService = rentalService;
        }

        protected override IEnumerable<OrderViewModel> Convert(IEnumerable<Order> domainModel)
        {
            return Mapper.Map<IEnumerable<OrderViewModel>>(domainModel);
        }

        protected override IEnumerable<Order> GetDomainModel()
        {
            return RentalService.GetOrdersById(User.Id);
        }
    }
}

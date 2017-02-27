using System.Collections.Generic;
using System.Windows.Forms;
using AutoMapper;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.View.Model;

namespace CarRental.View.Infra
{
    public class OrdersProvider : GridValueProvider<OrderDto, OrderViewModel>
    {
        public IOrderService OrderService { get; set; }
        public User User { get; set; }

        public OrdersProvider(User user, IOrderService orderService, DataGridView dataGridView) : base(dataGridView)
        {
            User = user;
            OrderService = orderService;
        }

        protected override IEnumerable<OrderViewModel> Convert(IEnumerable<OrderDto> domainModel)
        {
            return Mapper.Map<IEnumerable<OrderViewModel>>(domainModel);
        }

        protected override IEnumerable<OrderDto> GetDomainModel()
        {
            return OrderService.GetOrdersById(User.Id);
        }
    }
}

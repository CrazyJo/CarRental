using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using CarRental.Services;
using CarRental.Services.Entities;
using CarRental.View.Model;

namespace CarRental.View.Infra
{
    public class UserOrdersProvider : GridValueProvider<OrderDto, OrderViewModel>
    {
        public IOrderService OrderService { get; set; }
        public User User { get; set; }

        public UserOrdersProvider(User user, IOrderService orderService, DataGridView dataGridView) : base(dataGridView)
        {
            User = user;
            OrderService = orderService;
        }

        protected override IEnumerable<OrderViewModel> Convert(IEnumerable<OrderDto> domainModel)
        {
            return Mapper.Map<IEnumerable<OrderViewModel>>(domainModel);
        }

        protected override async Task<IEnumerable<OrderDto>> GetDomainModel()
        {
            var opDet = await OrderService.GetOrdersById(User.Id);
            return opDet.Successful ? opDet.Result : null;
        }
    }
}

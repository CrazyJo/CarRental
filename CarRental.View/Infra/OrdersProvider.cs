﻿using System.Collections.Generic;
using System.Threading.Tasks;
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

        public OrdersProvider(IOrderService orderService, DataGridView dataGridView) : base(dataGridView)
        {
            OrderService = orderService;
        }

        protected override IEnumerable<OrderViewModel> Convert(IEnumerable<OrderDto> domainModel)
        {
            return Mapper.Map<IEnumerable<OrderViewModel>>(domainModel);
        }

        protected override async Task<IEnumerable<OrderDto>> GetDomainModel()
        {
            var opDet = await OrderService.GetAllOrders();
            return opDet.Successful ? opDet.Result : null;
        }
    }
}

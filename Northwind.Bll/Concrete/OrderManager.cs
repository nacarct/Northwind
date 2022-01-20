using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;

namespace Northwind.Bll.Concrete
{
    public class OrderManager:BllBase<Order,DtoOrder>,IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _orderRepository = serviceProvider.GetService<IOrderRepository>();
        }

        public IQueryable OrderReport()
        {
            return _orderRepository.OrderReport();
        }
    }
}
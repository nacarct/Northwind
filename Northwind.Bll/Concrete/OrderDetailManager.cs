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
    public class OrderDetailManager:BllBase<OrderDetail,DtoOrderDetail>,IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _orderDetailRepository = serviceProvider.GetService<IOrderDetailRepository>();
        }
        
        public IQueryable OrderDetailReport()
        {
            return _orderDetailRepository.OrderDetailReport();
        }
    }
}
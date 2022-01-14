﻿using System;
using System.Collections.Generic;
using System.Linq;
using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;

namespace Northwind.Bll
{
    public class OrderManager:BllBase<Order,DtoOrder>,IOrderService
    {
        public readonly IOrderRepository orderRepository;

        public OrderManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }

        public IQueryable OrderReport()
        {
            return orderRepository.OrderReport();
        }
    }
}
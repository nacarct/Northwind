using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;

namespace Northwind.Bll
{
    public class CustomerManager:BllBase<Customer,DtoCustomer>,ICustomerService
    {
        public readonly ICustomerRepository customerRepository;

        public CustomerManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public IQueryable CustomerReport()
        {
            return customerRepository.CustomerReport();
        }
    }
}
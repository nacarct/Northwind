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
    public class CustomerManager:BllBase<Customer,DtoCustomer>,ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _customerRepository = serviceProvider.GetService<ICustomerRepository>();
        }

        public IQueryable CustomerReport()
        {
            return _customerRepository.CustomerReport();
        }
    }
}
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
    public class CustomerCustomerDemoManager:BllBase<CustomerCustomerDemo,DtoCustomerCustomerDemo>, ICustomerCustomerDemoService
    {
        private readonly ICustomerCustomerDemoRepository _customerCustomerDemoRepository;
        
        public CustomerCustomerDemoManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _customerCustomerDemoRepository = serviceProvider.GetService<ICustomerCustomerDemoRepository>();
        }

        public IQueryable CustomerCustomerDemoReport()
        {
            return _customerCustomerDemoRepository.CustomerCustomerDemoReport();
        }
    }
}
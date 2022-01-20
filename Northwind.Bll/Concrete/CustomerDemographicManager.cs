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
    public class CustomerDemographicManager:BllBase<CustomerDemographic,DtoCustomerDemographic>,ICustomerDemographicService
    {
        private readonly ICustomerDemographicRepository _customerDemographicRepository;

        public CustomerDemographicManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _customerDemographicRepository = serviceProvider.GetService<ICustomerDemographicRepository>();
        }

        public IQueryable CustomerDemographicReport()
        {
            return _customerDemographicRepository.CustomerDemographicReport();
        }
    }
}
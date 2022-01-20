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
    public class EmployeeTerritoryManager:BllBase<EmployeeTerritory, DtoEmployeeTerritory>,IEmployeeTerritoryService
    {
        private readonly IEmployeeTerritoryRepository _employeeTerritoryRepository;

        public EmployeeTerritoryManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _employeeTerritoryRepository = serviceProvider.GetService<IEmployeeTerritoryRepository>();
        }


        public IQueryable EmployeeTerritoryReport()
        {
            return _employeeTerritoryRepository.EmployeeTerritoryReport();
        }
    }
}
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
    public class EmployeeManager:BllBase<Employee,DtoEmployee>,IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _employeeRepository = serviceProvider.GetService<IEmployeeRepository>();
        }

        public IQueryable EmployeeReport()
        {
            return _employeeRepository.EmployeeReport();
        }
    }
}
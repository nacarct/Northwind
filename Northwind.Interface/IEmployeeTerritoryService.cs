using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IEmployeeTerritoryService : IGenericService<EmployeeTerritory, DtoEmployeeTerritory>
    {
        IQueryable EmployeeTerritoryReport();
    }
}
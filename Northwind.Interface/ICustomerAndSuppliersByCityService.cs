using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ICustomerAndSuppliersByCityService : IGenericService<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>
    {
        IQueryable CustomerAndSuppliersByCityReport();
    }
}
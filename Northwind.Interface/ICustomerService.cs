using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ICustomerService:IGenericService<Customer,DtoCustomer>
    {
        IQueryable CustomerReport();
    }
}
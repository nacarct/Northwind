using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ICustomerCustomerDemoService : IGenericService<CustomerCustomerDemo, DtoCustomerCustomerDemo>
    {
        IQueryable CustomerCustomerDemoReport();
    }
}
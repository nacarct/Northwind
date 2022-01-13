using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IOrdersQryService : IGenericService<OrdersQry, DtoOrdersQry>
    {
        IQueryable OrdersQryReport();
    }
}
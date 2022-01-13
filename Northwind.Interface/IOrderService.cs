using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IOrderService:IGenericService<Order,DtoOrder>
    {
        IQueryable OrderReport();
    }
}
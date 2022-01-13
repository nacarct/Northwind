using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IOrderDetailService : IGenericService<OrderDetail, DtoOrderDetail>
    {
        IQueryable OrderDetailReport();
    }
}
using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IQuarterlyOrderService : IGenericService<QuarterlyOrder, DtoQuarterlyOrder>
    {
        IQueryable QuarterlyOrderReport();
    }
}
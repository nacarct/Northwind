using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ICurrentProductListService : IGenericService<CurrentProductList, DtoCurrentProductList>
    {
        IQueryable CurrentProductListReport();
    }
}
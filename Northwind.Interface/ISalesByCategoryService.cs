using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ISalesByCategoryService : IGenericService<SalesByCategory, DtoSalesByCategory>
    {
        IQueryable SalesByCategoryReport();
    }
}
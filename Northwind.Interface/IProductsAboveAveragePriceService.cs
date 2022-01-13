using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IProductsAboveAveragePriceService : IGenericService<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>
    {
        IQueryable ProductsAboveAveragePriceReport();
    }
}
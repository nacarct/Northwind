using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IProductsAboveAveragePriceRepository
    {
        IQueryable ProductsAboveAveragePriceReport();
    }
}
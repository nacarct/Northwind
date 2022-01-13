using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ISalesByCategoryRepository
    {
        IQueryable SalesByCategoryReport();
    }
}
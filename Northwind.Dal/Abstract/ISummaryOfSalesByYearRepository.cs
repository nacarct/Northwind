using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ISummaryOfSalesByYearRepository
    {
        IQueryable SummaryOfSalesByYearReport();
    }
}
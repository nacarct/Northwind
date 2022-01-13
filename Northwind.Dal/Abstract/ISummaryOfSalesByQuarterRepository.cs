using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ISummaryOfSalesByQuarterRepository
    {
        IQueryable SummaryOfSalesByQuarterReport();
    }
}
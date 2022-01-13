using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IQuarterlyOrderRepository
    {
        IQueryable QuarterlyOrderReport();
    }
}
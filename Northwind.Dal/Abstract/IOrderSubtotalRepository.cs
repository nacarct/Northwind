using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IOrderSubtotalRepository
    {
        IQueryable OrderSubtotalReport();
    }
}
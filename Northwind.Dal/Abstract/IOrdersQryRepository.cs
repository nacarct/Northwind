using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IOrdersQryRepository
    {
        IQueryable OrdersQryReport();
    }
}
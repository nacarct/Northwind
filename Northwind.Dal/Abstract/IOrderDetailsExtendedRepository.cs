using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IOrderDetailsExtendedRepository
    {
        IQueryable OrderDetailsExtendedReport();
    }
}
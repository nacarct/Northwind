using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ICustomerAndSuppliersByCityRepository
    {
        IQueryable CustomerAndSuppliersByCityReport();
    }
}
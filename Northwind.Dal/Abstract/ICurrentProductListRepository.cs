using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ICurrentProductListRepository
    {
        IQueryable CurrentProductListReport();
    }
}
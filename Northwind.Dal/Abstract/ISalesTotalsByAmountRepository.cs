using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ISalesTotalsByAmountRepository
    {
        IQueryable SalesTotalsByAmountReport();
    }
}
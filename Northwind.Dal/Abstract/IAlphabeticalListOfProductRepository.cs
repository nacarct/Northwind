using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IAlphabeticalListOfProductRepository
    {
        IQueryable AlphabeticalListOfProductReport();
    }
}
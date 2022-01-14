using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class AlphabeticalListOfProductRepository:GenericRepository<AlphabeticalListOfProduct>,IAlphabeticalListOfProductRepository
    {
        public AlphabeticalListOfProductRepository(DbContext context) : base(context)
        {
            //Constructor
        }

        public IQueryable AlphabeticalListOfProductReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
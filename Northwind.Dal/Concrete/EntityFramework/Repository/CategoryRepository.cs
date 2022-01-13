using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context, DbSet<Category> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable CategoryReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
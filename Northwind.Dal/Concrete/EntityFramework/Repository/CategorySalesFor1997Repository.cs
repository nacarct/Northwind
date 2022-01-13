using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class CategorySalesFor1997Repository : GenericRepository<CategorySalesFor1997>, ICategorySalesFor1997Repository
    {
        public CategorySalesFor1997Repository(DbContext context, DbSet<CategorySalesFor1997> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable CategorySalesFor1997Report()
        {
            return _dbSet.AsQueryable();
        }
    }
}
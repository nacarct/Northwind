using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class CurrentProductListRepository : GenericRepository<CurrentProductList>, ICurrentProductListRepository
    {
        public CurrentProductListRepository(DbContext context, DbSet<CurrentProductList> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable CurrentProductListReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
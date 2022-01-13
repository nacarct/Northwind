using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class TerritoryRepository : GenericRepository<Territory>, ITerritoryRepository
    {
        public TerritoryRepository(DbContext context, DbSet<Territory> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable TerritoryReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
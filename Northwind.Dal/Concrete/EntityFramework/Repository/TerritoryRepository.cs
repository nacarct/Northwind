using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class TerritoryRepository : GenericRepository<Territory>, ITerritoryRepository
    {
        public TerritoryRepository(DbContext context) : base(context)
        {
            //Constructor
        }

        public IQueryable TerritoryReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
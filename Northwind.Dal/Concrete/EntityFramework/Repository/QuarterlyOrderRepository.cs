using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class QuarterlyOrderRepository : GenericRepository<QuarterlyOrder>, IQuarterlyOrderRepository
    {
        public QuarterlyOrderRepository(DbContext context, DbSet<QuarterlyOrder> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable QuarterlyOrderReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
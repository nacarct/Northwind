using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class OrderSubtotalRepository : GenericRepository<OrderSubtotal>, IOrderSubtotalRepository
    {
        public OrderSubtotalRepository(DbContext context, DbSet<OrderSubtotal> dbSet) : base(context)
        {
            //Constructor
        }

        public IQueryable OrderSubtotalReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
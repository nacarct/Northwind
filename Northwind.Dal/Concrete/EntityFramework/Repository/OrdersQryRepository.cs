using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class OrdersQryRepository : GenericRepository<OrdersQry>, IOrdersQryRepository
    {
        public OrdersQryRepository(DbContext context, DbSet<OrdersQry> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable OrdersQryReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
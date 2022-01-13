using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class OrderRepository:GenericRepository<Order>,IOrderRepository
    {
        public OrderRepository(DbContext context, DbSet<Order> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable OrderReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
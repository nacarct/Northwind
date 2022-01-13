using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(DbContext context, DbSet<OrderDetail> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable OrderDetailReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
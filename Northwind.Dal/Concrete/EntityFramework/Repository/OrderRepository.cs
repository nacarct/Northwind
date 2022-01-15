using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class OrderRepository:GenericRepository<Order>,IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context)
        {
            //Constructor
        }

        public IQueryable OrderReport()
        {
            var t = _dbSet.Where(o => o.OrderId == 10252).ToList();

            return null;
        }
    }
}
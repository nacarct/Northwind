using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class ShipperRepository : GenericRepository<Shipper>, IShipperRepository
    {
        public ShipperRepository(DbContext context, DbSet<Shipper> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable ShipperReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
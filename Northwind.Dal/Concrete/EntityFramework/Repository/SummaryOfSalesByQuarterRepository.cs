using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class SummaryOfSalesByQuarterRepository : GenericRepository<SummaryOfSalesByQuarter>, ISummaryOfSalesByQuarterRepository
    {
        public SummaryOfSalesByQuarterRepository(DbContext context) : base(context)
        {
            //Constructor
        }

        public IQueryable SummaryOfSalesByQuarterReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class CustomerDemographicRepository : GenericRepository<CustomerDemographic>, ICustomerDemographicRepository
    {
        public CustomerDemographicRepository(DbContext context, DbSet<CustomerDemographic> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable CustomerDemographicReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
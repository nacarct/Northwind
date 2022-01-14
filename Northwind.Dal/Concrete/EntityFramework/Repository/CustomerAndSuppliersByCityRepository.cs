using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class CustomerAndSuppliersByCityRepository : GenericRepository<CustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityRepository
    {
        public CustomerAndSuppliersByCityRepository(DbContext context) :base(context)
        {
            //Constructor
        }

        public IQueryable CustomerAndSuppliersByCityReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
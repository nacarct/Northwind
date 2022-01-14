using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class CustomerCustomerDemoRepository : GenericRepository<CustomerCustomerDemo>, ICustomerCustomerDemoRepository
    {
        public CustomerCustomerDemoRepository(DbContext context) : base(context)
        {
            //Constructor
        }

        public IQueryable CustomerCustomerDemoReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
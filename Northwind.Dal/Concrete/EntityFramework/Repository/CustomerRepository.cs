using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class CustomerRepository:GenericRepository<Customer>,ICustomerRepository
    {
        public CustomerRepository(DbContext context, DbSet<Customer> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable CustomerReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
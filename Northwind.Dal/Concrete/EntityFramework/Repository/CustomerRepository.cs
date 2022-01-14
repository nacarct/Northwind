using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class CustomerRepository:GenericRepository<Customer>,ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        {
            //Constructor
        }

        public IQueryable CustomerReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
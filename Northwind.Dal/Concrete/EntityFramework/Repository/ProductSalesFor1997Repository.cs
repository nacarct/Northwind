using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class ProductSalesFor1997Repository : GenericRepository<ProductSalesFor1997>, IProductSalesFor1997Repository
    {
        public ProductSalesFor1997Repository(DbContext context) : base(context)
        {
            //Constructor
        }

        public IQueryable ProductSalesFor1997Report()
        {
            return _dbSet.AsQueryable();
        }
    }
}
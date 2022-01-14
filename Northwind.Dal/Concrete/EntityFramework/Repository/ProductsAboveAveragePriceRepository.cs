using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class ProductsAboveAveragePriceRepository : GenericRepository<ProductsAboveAveragePrice>, IProductsAboveAveragePriceRepository
    {
        public ProductsAboveAveragePriceRepository(DbContext context) : base(context)
        {
            //Constructor
        }

        public IQueryable ProductsAboveAveragePriceReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
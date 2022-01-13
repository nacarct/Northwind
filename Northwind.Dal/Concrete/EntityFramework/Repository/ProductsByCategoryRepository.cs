﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class ProductsByCategoryRepository : GenericRepository<ProductsByCategory>, IProductsByCategoryRepository
    {
        public ProductsByCategoryRepository(DbContext context, DbSet<ProductsByCategory> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable ProductsByCategoryReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
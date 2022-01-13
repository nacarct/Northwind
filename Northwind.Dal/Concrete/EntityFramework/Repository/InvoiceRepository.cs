using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DbContext context, DbSet<Invoice> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable InvoiceReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
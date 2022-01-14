using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DbContext context) : base(context)
        {
            //Constructor
        }

        public IQueryable InvoiceReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
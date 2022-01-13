using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IInvoiceRepository
    {
        IQueryable InvoiceReport();
    }
}
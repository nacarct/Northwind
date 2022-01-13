using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IInvoiceService : IGenericService<Invoice, DtoInvoice>
    {
        IQueryable InvoiceReport();
    }
}
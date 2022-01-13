using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ISupplierService : IGenericService<Supplier, DtoSupplier>
    {
        IQueryable SupplierReport();
    }
}
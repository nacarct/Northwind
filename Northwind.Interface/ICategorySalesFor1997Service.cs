using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ICategorySalesFor1997Service : IGenericService<CategorySalesFor1997, DtoCategorySalesFor1997>
    {
        IQueryable CategorySalesFor1997Report();
    }
}
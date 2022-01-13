using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IProductSalesFor1997Service : IGenericService<ProductSalesFor1997, DtoProductSalesFor1997>
    {
        IQueryable ProductSalesFor1997Report();
    }
}
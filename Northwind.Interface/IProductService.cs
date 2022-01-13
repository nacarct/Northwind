using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IProductService : IGenericService<Product, DtoProduct>
    {
        IQueryable ProductReport();
    }
}
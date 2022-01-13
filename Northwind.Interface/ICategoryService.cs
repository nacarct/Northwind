using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ICategoryService : IGenericService<Category, DtoCategory>
    {
        IQueryable CategoryReport();
    }
}
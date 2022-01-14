using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;

namespace Northwind.Dal.Abstract
{
    public interface ICustomerRepository
    {
        IQueryable CustomerReport();
    }
}
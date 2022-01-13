using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ISalesTotalsByAmountService : IGenericService<SalesTotalsByAmount, DtoSalesTotalsByAmount>
    {
        IQueryable SalesTotalsByAmountReport();
    }
}
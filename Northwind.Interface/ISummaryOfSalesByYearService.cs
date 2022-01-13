using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ISummaryOfSalesByYearService : IGenericService<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>
    {
        IQueryable SummaryOfSalesByYearReport();
    }
}
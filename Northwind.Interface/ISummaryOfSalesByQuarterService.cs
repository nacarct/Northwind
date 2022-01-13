using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ISummaryOfSalesByQuarterService : IGenericService<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>
    {
        IQueryable SummaryOfSalesByQuarterReport();
    }
}
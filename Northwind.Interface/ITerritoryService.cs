using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ITerritoryService : IGenericService<Territory, DtoTerritory>
    {
        IQueryable TerritoryReport();
    }
}
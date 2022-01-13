using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IRegionService : IGenericService<Region, DtoRegion>
    {
        IQueryable RegionReport();
    }
}
using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IShipperService : IGenericService<Shipper, DtoShipper>
    {
        IQueryable ShipperReport();
    }
}
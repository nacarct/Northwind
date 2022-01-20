using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;

namespace Northwind.Bll.Concrete
{
    public class ShipperManager:BllBase<Shipper,DtoShipper>,IShipperService
    {
        private readonly IShipperRepository _shipperRepository;
        
        public ShipperManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _shipperRepository = serviceProvider.GetService<IShipperRepository>();
        }

        public IQueryable ShipperReport()
        {
            return _shipperRepository.ShipperReport();
        }
    }
}
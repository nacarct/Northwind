using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ApiBaseController<IShipperService,Shipper,DtoShipper>
    {
        private IShipperService _shipperService;

        public ShipperController(IShipperService shipperService) : base(shipperService)
        {
            _shipperService = shipperService;
        }
    }
}
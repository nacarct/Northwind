using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoryController : ApiBaseController<ITerritoryService,Territory,DtoTerritory>
    {
        private readonly ITerritoryService _territoryService;

        public TerritoryController(ITerritoryService territoryService) : base(territoryService)
        {
            _territoryService = territoryService;
        }
    }
}
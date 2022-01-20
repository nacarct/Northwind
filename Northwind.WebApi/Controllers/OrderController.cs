using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ApiBaseController<IOrderService,Order,DtoOrder>
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService genericService) : base(genericService)
        {
            _orderService = genericService;
        }

        [HttpGet("FindOrder")]
        public IResponse<DtoOrder> FindOrder()
        {
            try
            {
                var t = _orderService.OrderReport();
                return null;
            }
            catch (Exception e)
            {
                return new Response<DtoOrder>()
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }
    }
}

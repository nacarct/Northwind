using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public OrderController(IOrderService genericService) : base(genericService)
        {
        }
    }
}

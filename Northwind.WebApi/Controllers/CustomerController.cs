using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Routing;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ApiBaseController<ICustomerService,Customer,DtoCustomer>
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService) : base(customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("FindString")]
        public IResponse<DtoCustomer> Find(string id)
        {
            try
            {
                return _customerService.Find(id);
            }
            catch (Exception e)
            {
                return new Response<DtoCustomer>()
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }
        
        [HttpGet("FindExp")]
        public IResponse<DtoCustomer> FindExp(string id)
        {
            try
            {
                return new Response<DtoCustomer>()
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = "Success",
                    Data = _customerService.GetAllList(c=>c.CustomerId == id).FirstOrDefault()
                };
            }
            catch (Exception e)
            {
                return new Response<DtoCustomer>()
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }

            //return new Response<DtoCustomer>()
            //{
            //    StatusCode = StatusCodes.Status500InternalServerError,
            //    Message = $"Error : ",
            //    Data = null
            //};
        }
    }
}

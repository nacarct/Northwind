using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerCustomerDemoController : ApiBaseController<ICustomerCustomerDemoService,CustomerCustomerDemo,DtoCustomerCustomerDemo>
    {
        private readonly ICustomerCustomerDemoService _customerCustomerDemoService;

        public CustomerCustomerDemoController(ICustomerCustomerDemoService customerCustomerDemoService) : base(customerCustomerDemoService)
        {
            _customerCustomerDemoService = customerCustomerDemoService;
        }
    }
}
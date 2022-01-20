using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ApiBaseController<ICategoryService,Category,DtoCategory>
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService genericService): base(genericService)
        {
            _categoryService = genericService;
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Northwind.Entity.Base;
using Northwind.Entity.IBase;
using Northwind.Interface;

namespace Northwind.WebApi.Base
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ApiBaseController<TInterface,T,TDto> : ControllerBase where TInterface : IGenericService<T,TDto> where T : EntityBase where TDto : DtoBase
    {
        private readonly TInterface _genericService;

        public ApiBaseController(TInterface genericService)
        {
            _genericService = genericService;
        }

        [HttpGet("Find")]
        public IResponse<TDto> Find(int id)
        {
            try
            {
                return _genericService.Find(id);
            }
            catch (Exception e)
            {
                return new Response<TDto>()
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }

        [HttpGet("GetAll")]
        public IResponse<List<TDto>> GetAll()
        {
            try
            {
                var data = _genericService.GetAll();

                return data;
            }
            catch (Exception e)
            {
                return new Response<List<TDto>>()
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }
    }
}

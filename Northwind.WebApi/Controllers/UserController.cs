using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public IResponse<DtoUserToken> Login(DtoLogin dtoLogin)
        {
            try
            {
                var login = _userService.Login(dtoLogin);
                return login;
            }
            catch (Exception e)
            {
                return new Response<DtoUserToken>()
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }
        
        [HttpPost("Register")]
        [AllowAnonymous]
        public IResponse<DtoRegisterUser> Register(DtoRegisterUser register)
        {
            try
            {
                return _userService.Register(register);
            }
            catch (Exception e)
            {
                return new Response<DtoRegisterUser>()
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }
    }
}
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;

namespace Northwind.Bll.Concrete
{
    public class UserManager:BllBase<User,DtoUser>,IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public UserManager(IServiceProvider serviceProvider, IConfiguration configuration) : base(serviceProvider)
        {
            _configuration = configuration;
            _userRepository = serviceProvider.GetService<IUserRepository>();
        }

        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            var password = login.Password;
            login.Password = EncryptionManager.Md5Hash(password);
            
            var user = _userRepository.Login(ObjectMapper.Mapper.Map<User>(login));

            if (user is not null)
            {
                var dtoLoginUser = ObjectMapper.Mapper.Map<DtoLoginUser>(user);
                var token = new TokenManager(_configuration).CreateAccessToken(dtoLoginUser);
                
                var userToken = new DtoUserToken()
                {
                    DtoLoginUser = dtoLoginUser,
                    AccessToken = token
                };
                
                return new Response<DtoUserToken>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Token is success.",
                    Data = userToken
                };
            }
            else
            {
                return new Response<DtoUserToken>()
                {
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Message = "User Code or Password is wrong !",
                    Data = null
                };
            }
        }

        public IResponse<DtoRegisterUser> Register(DtoRegisterUser register)
        {
            var password = register.Password;
            register.Password = EncryptionManager.Md5Hash(password);
            
            try
            {
                return new Response<DtoRegisterUser>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = ObjectMapper.Mapper.Map<DtoRegisterUser>(_userRepository.Register(ObjectMapper.Mapper.Map<User>(register)))
                };
            }
            catch (Exception e)
            {
                return new Response<DtoRegisterUser>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }
    }
}
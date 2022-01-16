using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Dal.Concrete.EntityFramework.Repository;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;

namespace Northwind.Bll
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
    }
}
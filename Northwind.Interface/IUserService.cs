using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IUserService:IGenericService<User,DtoUser>
    {
        IResponse<DtoUserToken> Login(DtoLogin login);
        IResponse<DtoRegisterUser> Register(DtoRegisterUser register);
    }
}
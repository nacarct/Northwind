using Northwind.Entity.Models;

namespace Northwind.Dal.Abstract
{
    public interface IUserRepository
    {
        User Login(User login);
        User Register(User register);
    }
}
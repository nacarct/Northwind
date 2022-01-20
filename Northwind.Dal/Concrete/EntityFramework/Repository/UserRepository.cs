using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class UserRepository:GenericRepository<User>,IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
            //Constructor
        }

        public User Login(User login)
        {
            return _dbSet.FirstOrDefault(u => u.UserCode == login.UserCode && u.Password == login.Password);
        }

        public User Register(User register)
        {
            _context.Entry(register).State = EntityState.Added;
            _context.Add(register);
            _context.SaveChanges();

            return register;
        }
    }
}
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class EmployeeTerritoryRepository : GenericRepository<EmployeeTerritory>, IEmployeeTerritoryRepository
    {
        public EmployeeTerritoryRepository(DbContext context, DbSet<EmployeeTerritory> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable EmployeeTerritoryReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}
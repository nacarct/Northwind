using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Northwind.Entity.IBase;

namespace Northwind.Dal.Abstract
{
    public interface IGenericRepository<T> where T:IEntityBase
    {
        T Add(T entity);
        T Update(T entity);
        T Find(int id);
        T Find(string id);
        T Get(int id);
        List<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        bool Delete(int id);
        bool Delete(T entity);
    }
}
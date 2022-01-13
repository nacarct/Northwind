using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Northwind.Entity.Base;
using Northwind.Entity.IBase;

namespace Northwind.Interface
{
    public interface IGenericService<T, TDto> where T:IEntityBase where TDto:IDtoBase
    {
        IResponse<List<TDto>> GetAll();
        IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression);
        IResponse<TDto> Find(int id);
        IQueryable<T> GetQueryable();
        IResponse<TDto> Add(TDto entity,bool saveChanges = true);
        Task<TDto> AddAsync(TDto entity);
        TDto Update(TDto entity);
        Task<TDto> UpdateAsync(TDto entity);
        bool DeleteById(int id);
        Task<bool> DeleteByIdAsync(int id);
        bool Delete(TDto entity);
        Task<bool> DeleteAsync(TDto entity);

        void Save();
    }
}
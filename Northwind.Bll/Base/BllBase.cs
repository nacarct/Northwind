using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Entity.IBase;

namespace Northwind.Bll.Base
{
    public class BllBase<T, TDto> : IGenericService<T, TDto> where T : EntityBase where TDto : DtoBase
    {
        #region Variables

        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;
        private readonly IGenericRepository<T> _repository;
        private readonly Mapper _mapper;

        public BllBase(IServiceProvider serviceProvider)
        {
            _unitOfWork = serviceProvider.GetService<IUnitOfWork>();
            _repository = _unitOfWork.GetRepository<T>();
            _serviceProvider = serviceProvider;
            _mapper = new Mapper((IConfigurationProvider) serviceProvider);
        }

        #endregion

        public IResponse<TDto> Add(TDto entity,bool saveChanges = true)
        {
            try
            {
                var resolvedResut = "";
                var TResult = _repository.Add(_mapper.Map<T>(entity));
                resolvedResut = String.Join(',', TResult.GetType().GetProperties().Select(x => $" * {x.Name}"));
                
                if(saveChanges)
                    Save();

                return new Response<TDto>
                {
                    StatusCode = 100,
                    Message = "Success",
                    Data = _mapper.Map<T, TDto>(TResult)
                };
            }
            catch (Exception e)
            {
                return new Response<TDto>
                {
                    StatusCode = 200,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }

        public Task<TDto> AddAsync(TDto entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TDto entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IResponse<TDto> Find(int id)
        {
            try
            {
                return new Response<TDto>
                {
                    StatusCode = 88,
                    Message = "Success",
                    Data = _mapper.Map<T, TDto>(_repository.Find(id))
                };
            }
            catch (Exception e)
            {
                return new Response<TDto>
                {
                    StatusCode = 999,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }

        public IResponse<List<TDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public TDto Update(TDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<TDto> UpdateAsync(TDto entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.SaveChanges();
        }
    }
}
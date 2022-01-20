using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Entity.IBase;
using Microsoft.AspNetCore.Http;

namespace Northwind.Bll.Base
{
    public class BllBase<T, TDto> : IGenericService<T, TDto> where T : EntityBase where TDto : DtoBase
    {
        #region Variables

        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<T> _repository;

        protected BllBase(IServiceProvider serviceProvider)
        {
            _unitOfWork = serviceProvider.GetService<IUnitOfWork>();
            _repository = _unitOfWork!.GetRepository<T>();
        }

        #endregion

        public IResponse<TDto> Add(TDto entity,bool saveChanges = true)
        {
            try
            {
                var result = _repository.Add(ObjectMapper.Mapper.Map<T>(entity));
                //var resolvedResult = string.Join(',', result.GetType().GetProperties().Select(x => $" * {x.Name}"));
                
                if(saveChanges)
                    Save();

                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = ObjectMapper.Mapper.Map<T, TDto>(result)
                };
            }
            catch (Exception e)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
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

        public IResponse<bool> DeleteById(int id, bool saveChanges = true)
        {
            try
            {
                _repository.Delete(id);
                
                if(saveChanges)
                    Save();

                return new Response<bool>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = true,

                };
            }
            catch (Exception e)
            {
                return new Response<bool>()
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = false
                };
            }
        }

        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<TDto> GetAllList(Expression<Func<T, bool>> expression)
        {
            List<T> list = _repository.GetAll();
            return list.Select(x => ObjectMapper.Mapper.Map<TDto>(x)).ToList();
        }

        public IResponse<TDto> Find(int id)
        {
            try
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = ObjectMapper.Mapper.Map<T, TDto>(_repository.Find(id))
                };
            }
            catch (Exception e)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }

        public IResponse<TDto> Find(string id)
        {
            try
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = ObjectMapper.Mapper.Map<T, TDto>(_repository.Find(id))
                };
            }
            catch (Exception e)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }

        public IResponse<List<TDto>> GetAll()
        {
            try
            {
                List<T> list = _repository.GetAll();
                //var dtoList = ObjectMapper.Mapper.Map<List<TDto>>(list);
                var dtoList = list.Select(x => ObjectMapper.Mapper.Map<TDto>(x)).ToList();

                return new Response<List<TDto>>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = dtoList
                };
            }
            catch (Exception e)
            {
                return new Response<List<TDto>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
        }

        public IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression)
        {
            try
            {
                List<T> list = _repository.GetAll(expression:expression).ToList();
                
                var dtoList = list.Select(x => ObjectMapper.Mapper.Map<TDto>(x)).ToList();

                return new Response<List<TDto>>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = dtoList
                };
            }
            catch (Exception e)
            {
                return new Response<List<TDto>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error : {e.Message}",
                    Data = null
                };
            }
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
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;

namespace Northwind.Bll.Concrete
{
    public class CategoryManager:BllBase<Category,DtoCategory>,ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        
        public CategoryManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _categoryRepository = serviceProvider.GetService<ICategoryRepository>();
        }

        public IQueryable CategoryReport()
        {
            return _categoryRepository.CategoryReport();
        }
    }
}
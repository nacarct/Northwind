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
    public class ProductManager:BllBase<Product,DtoProduct>,IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _productRepository = serviceProvider.GetService<IProductRepository>();
        }

        public IQueryable ProductReport()
        {
            return _productRepository.ProductReport();
        }
    }
}
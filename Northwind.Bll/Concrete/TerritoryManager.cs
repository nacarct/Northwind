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
    public class TerritoryManager:BllBase<Territory,DtoTerritory>,ITerritoryService
    {
        private readonly ITerritoryRepository _territoryRepository;

        public TerritoryManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _territoryRepository = serviceProvider.GetService<ITerritoryRepository>();
        }

        public IQueryable TerritoryReport()
        {
            return _territoryRepository.TerritoryReport();
        }
    }
}
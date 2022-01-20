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
    public class RegionManager:BllBase<Region,DtoRegion>, IRegionService
    {
        private readonly IRegionRepository _regionRepository;

        public RegionManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _regionRepository = serviceProvider.GetService<IRegionRepository>();
        }

        public IQueryable RegionReport()
        {
            return _regionRepository.RegionReport();
        }
    }
}
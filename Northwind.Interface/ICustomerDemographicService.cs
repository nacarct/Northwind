﻿using System.Linq;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface ICustomerDemographicService : IGenericService<CustomerDemographic, DtoCustomerDemographic>
    {
        IQueryable CustomerDemographicReport();
    }
}
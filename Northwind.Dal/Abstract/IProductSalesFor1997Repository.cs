﻿using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IProductSalesFor1997Repository
    {
        IQueryable ProductSalesFor1997Report();
    }
}
using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoCategorySalesFor1997 : DtoBase
    {
        public string CategoryName { get; set; }
        public decimal? CategorySales { get; set; }
    }
}

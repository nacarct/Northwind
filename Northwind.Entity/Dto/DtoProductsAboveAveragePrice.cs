using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoProductsAboveAveragePrice : DtoBase
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoOrderSubtotal : DtoBase
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoCurrentProductList : DtoBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}

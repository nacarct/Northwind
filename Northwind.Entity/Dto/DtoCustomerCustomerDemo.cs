using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoCustomerCustomerDemo : DtoBase
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }
    }
}

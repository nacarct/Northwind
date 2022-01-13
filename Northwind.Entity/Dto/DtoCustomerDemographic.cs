using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoCustomerDemographic : DtoBase
    {
        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }
    }
}

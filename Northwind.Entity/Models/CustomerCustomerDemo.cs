using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class CustomerCustomerDemo : EntityBase
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerDemographic CustomerType { get; set; }
    }
}

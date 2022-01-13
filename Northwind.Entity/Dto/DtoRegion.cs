using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoRegion : DtoBase
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
    }
}

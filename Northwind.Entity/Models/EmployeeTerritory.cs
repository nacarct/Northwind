using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class EmployeeTerritory : EntityBase
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Territory Territory { get; set; }
    }
}

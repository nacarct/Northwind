﻿using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class Territory : EntityBase
    {
        public Territory()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritory>();
        }

        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace NetCoreUseSQL.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}

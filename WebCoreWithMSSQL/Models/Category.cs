using System;
using System.Collections.Generic;

namespace WebCoreWithMSSQL.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}

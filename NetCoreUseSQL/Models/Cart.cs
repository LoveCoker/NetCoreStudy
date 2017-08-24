using System;
using System.Collections.Generic;

namespace NetCoreUseSQL.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Count { get; set; }
    }
}

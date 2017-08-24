using System;
using System.Collections.Generic;

namespace NetCoreUseSQL.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int BookId { get; set; }
    }
}

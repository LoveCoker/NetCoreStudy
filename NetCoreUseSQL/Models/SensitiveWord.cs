using System;
using System.Collections.Generic;

namespace NetCoreUseSQL.Models
{
    public partial class SensitiveWord
    {
        public int Id { get; set; }
        public string Original { get; set; }
        public bool IsForbid { get; set; }
        public bool IsReplace { get; set; }
        public string Replace { get; set; }
    }
}

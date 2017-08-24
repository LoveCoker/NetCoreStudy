using System;
using System.Collections.Generic;

namespace NetCoreUseSQL.Models
{
    public partial class Option
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Enabled { get; set; }
    }
}

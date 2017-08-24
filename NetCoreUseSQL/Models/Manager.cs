using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreUseSQL.Models
{
    public class Manager
    {
        public int MId { set; get; }
        public string MName { set; get; }
        public string MPwd { set; get; }
        public int State { set; get; }
    }
}

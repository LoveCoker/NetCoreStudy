using System;
using System.Collections.Generic;

namespace NetCoreUseSQL.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
        public byte Status { get; set; }
    }
}

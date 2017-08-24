using System;
using System.Collections.Generic;

namespace NetCoreUseSQL.Models
{
    public partial class Captcha
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public bool Actived { get; set; }
        public DateTime Expired { get; set; }
    }
}

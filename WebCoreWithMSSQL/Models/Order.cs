using System;
using System.Collections.Generic;

namespace WebCoreWithMSSQL.Models
{
    public partial class Order
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public string PostAddress { get; set; }
        public int State { get; set; }
    }
}

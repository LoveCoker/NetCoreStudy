using System;
using System.Collections.Generic;

namespace NetCoreUseSQL.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

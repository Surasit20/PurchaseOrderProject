﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class OrderDetailDTO
    {
    
        public string? Purchaser { get; set; }
        public DateTime? OrderDateNow { get; set; } = DateTime.Now;
        public DateTime? OrderDate { get; set; } = DateTime.Now;
        public decimal? TotalPrice { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();
        public int? SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
        public decimal? Discount { get; set; }
        public int? Status { get; set; }
    }
}

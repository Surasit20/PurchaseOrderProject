using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class OrderItemDTO
    {
        public int? Id;
        public string? Title { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public int? OrderId { get; set; }
        public int? No { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public string? Unit { get; set; }
        public decimal? TotalPrice { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shared
{
    public class Order
    {
        public int Id { get; set; }
        [StringLength(200, MinimumLength = 4)]
        public string? Purchaser { get; set; }
        public DateTime? OrderDateNow { get; set; } = DateTime.Now;
        public DateTime? OrderDate { get; set; } = DateTime.Now;
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TotalPrice { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();
        public int? SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Discount { get; set; }
        public int? Status { get; set; } = 0;

    }
}

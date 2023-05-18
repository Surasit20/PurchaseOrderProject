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
    public class Product
    {
        public int Id { get; set; }

        [StringLength(300, MinimumLength = 2)]
        public string? Title { get; set; } = string.Empty;
        [StringLength(300, MinimumLength = 2)]
        public string? Description { get; set; } = string.Empty;
        [StringLength(2000, MinimumLength = 2)]
        public string? ImageUrl { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        [StringLength(50, MinimumLength = 1)]
        public string? Unit { get; set; } = string.Empty;
    
        public int? ProductTypeId { get; }
        [JsonIgnore]
        public ProductType? ProductType { get; }
        [JsonIgnore]
        public ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();
    }
}

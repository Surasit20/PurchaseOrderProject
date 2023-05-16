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
      
        public string? Title { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        public string? Unit { get; set; } = string.Empty;
    
        public int? ProductTypeId { get; }
        [JsonIgnore]
        public ProductType? ProductType { get; }
        [JsonIgnore]
        public ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();
    }
}

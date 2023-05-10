using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class OrderItem
    {
        //public Order Order { get; set; }
        // public int OrderId { get; set; }
        // public Product Product { get; set; }
        //public int ProductId { get; set; }
        //public ProductType ProductType { get; set; }
        //public int ProductTypeId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
  
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
    }
}

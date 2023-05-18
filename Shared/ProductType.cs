﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ProductType
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; } = string.Empty;
        public ICollection<Product> Products { get; } 
    }
}

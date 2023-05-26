using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter {0}.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter {0}.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter {0}.")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Please enter {0}.")]
        public string TaxID { get; set; }
        [Required(ErrorMessage = "Please enter {0}.")]
        public string OfficeName { get; set; }
     
        public ICollection<Order> Orders { get; set; }
     


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models
{
    [Table("Vendor")]
    public class Vendor
    {
       [Key]
        public int VendorId { get; set; }

        public string Name { get; set;}
        public string Code { get; set;}

        public string Description { get; set;}

        //public List<Product> Products { get; set; }

    }
}

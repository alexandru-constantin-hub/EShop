using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models
{
    [Table("Product")]
    public class Product

    {
         
     
           [Key]
            public int ProductId { get; set; }

            public string Name { get; set; }
            public string Code { get; set; }

            public string Description { get; set; }

            public float Price { get; set; }

            public string BarCode { get; set; }
        
            public string Model { get; set; }


            //public int VendorId { get; set; }
            //public Vendor Vendor { get; set; }


    }
}

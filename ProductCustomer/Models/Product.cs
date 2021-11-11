using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCustomer.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Customer { get; set; }
        public int Price { get; set; }
        [DisplayName("Product name")]
        public string ProductName { get; set; }
    }
}

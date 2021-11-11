using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCustomer.Models
{
    public class Cost
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Cost")]
        [Required]
        public string CostName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="The Amount Must Be Positive!")]
        public int Amount { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEntityFramework
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public int? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(10)]
        public string OrderDescription { get; set; }

        public virtual Customer customer { get; set; } // property that is going to hold our customer instance
    }
}

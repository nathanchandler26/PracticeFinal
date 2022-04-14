using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeFinal.Models
{
    public class RestaurantInfo
    {
        [Key]
        [Required]
        public int RestaurantId { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        [Required]
        //[Range(1, 10)]
        public string Price { get; set; }

        [Required]
        public int Rating { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Max 40 tecken")]
        public string Name { get; set; }

        [Range(0, 1000000)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Max 20 tecken")]
        public string Category { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Max 25 tecken")]
        public string Shelf { get; set; }

        [Range(1, 10000)]
        public int Count { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Max 50 tecken")]
        public string Description { get; set; }


    }
}
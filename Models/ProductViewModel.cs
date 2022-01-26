using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Storage.Controllers;
using Storage.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{


    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public int Count { get; set; }

        public string Category { get; set; }

        public int InventoryValue { get; set; }

    }


}
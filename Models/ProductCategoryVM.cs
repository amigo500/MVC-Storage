﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class ProductCategoryVM
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }

        public string Category { get; set; }
        public string Name { get; set; }
    }
}
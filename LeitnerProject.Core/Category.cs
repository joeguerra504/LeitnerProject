﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitnerProject.Core
{
    public class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public List<Subcategory> Subcategories { get; set; }

    }
}
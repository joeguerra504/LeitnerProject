using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitnerProject.Core
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        // Each Subcategory needs to have a Parent Category
        public Category Category { get; set; }
        public int CategoryId { get; set; }



    }
}

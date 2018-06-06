using System.Collections.Generic;

namespace LeitnerProject.Core
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Subcategory> Subcategories { get; set; }

    }
}

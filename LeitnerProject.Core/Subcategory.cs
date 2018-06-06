namespace LeitnerProject.Core
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // Each Subcategory needs to have a Parent Category
        public Category Category { get; set; }
        public int CategoryId { get; set; }



    }
}

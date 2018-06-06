using System.Collections.Generic;

namespace LeitnerProject.Core
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Answer> Answers { get; set; }

        // Question has a parent of Subcategory
        public Subcategory Subcategory { get; set; }
        public int SubcategoryId { get; set; }


    }
}

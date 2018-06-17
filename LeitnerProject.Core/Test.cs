using System.Collections.Generic;

namespace LeitnerProject.Core
{
    public class Test
    {
        public int Id { get; set; }
        public string TestType { get; set; }
        public int QuestionTotal { get; set; }

      public List<Question> Questions { get; set; }


   }
}

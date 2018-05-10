using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitnerProject.Core
{
    public class Answer
    {
        public int Id { get; set; }
        public string Title { get; set; }
      //  public List<Question> Questions { get; set; }
      // error "unable to determine the relationship represented by Answer.Questions of type List<Question>
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitnerProject.Core
{
    public class QuestionAnswer
    {
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public Question Question { get; set; }
        public Answer Answer { get; set; }

    }
}

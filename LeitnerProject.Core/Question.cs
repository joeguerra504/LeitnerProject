﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitnerProject.Core
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Answer> Answers { get; set; }
        // public int AnswerId { get; set; }
        public List<QuestionAnswer> QuestionAnswers { get; set; }
       
    }
}

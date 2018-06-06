namespace LeitnerProject.Core
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }

        // Each Answer has a parent Question
        public Question Question { get; set; }
        public int QuestionId { get; set; }



    }
}

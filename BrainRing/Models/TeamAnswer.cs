namespace BrainRing.Models
{
    public class TeamAnswer
    {
        public int Id { get; set; }
        public int CommandNumber { get; set; }
        public int QuestionNumber { get; set; }
        public string Answer { get; set; }
        public TimeOnly AnswerTime { get; set; }
    }
}

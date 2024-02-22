namespace BrainRing.Models
{
    public class TeamAnswer
    {
        public int Id { get; set; }
        public int Command { get; set; }
        public int Question { get; set; }
        public string Answer { get; set; }
        public DateTime AnswerTime { get; set; }
    }
}

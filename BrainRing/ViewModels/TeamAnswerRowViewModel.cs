namespace BrainRing.ViewModels
{
    public class TeamAnswerRowViewModel
    {
        public int QuestionNumber { get; set; }
        public IEnumerable<Cell> Cells { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BrainRing.ViewModels
{
    public class TeamAnswerViewModel
    {
        public int CommandNumber { get; set; } = 1;
        public int QuestionNumber { get; set; } = 1;
        public string Answer { get; set; }
    }
}

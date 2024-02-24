using BrainRing.ViewModels;

namespace BrainRing.Interfaces
{
    public interface ITeamAnswerService
    {
        Task<TeamAnswerViewModel> AddTeamAnswer(TeamAnswerViewModel answerViewModel);
    }
}

using BrainRing.ViewModels;
using System.Data;

namespace BrainRing.Interfaces
{
    public interface ITeamAnswerService
    {
        Task<TeamAnswerViewModel> AddTeamAnswer(TeamAnswerViewModel answerViewModel);
        Task<IEnumerable<TeamAnswerRowViewModel>> GetAnswerRows();
    }
}

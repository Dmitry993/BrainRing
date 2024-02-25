using BrainRing.Models;
using BrainRing.ViewModels;

namespace BrainRing.Interfaces
{
    public interface ITeamAnswerRepository
    {
        Task AddTeamAnswer(TeamAnswerViewModel answerViewModel);
        Task<IEnumerable<TeamAnswerRowViewModel>> GetAnswerRows();
    }
}

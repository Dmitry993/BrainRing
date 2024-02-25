using BrainRing.Interfaces;
using BrainRing.Models;
using BrainRing.ViewModels;

namespace BrainRing.Services
{
    public class TeamAnswerService(ITeamAnswerRepository repository) : ITeamAnswerService
    {
        public async Task<TeamAnswerViewModel> AddTeamAnswer(TeamAnswerViewModel answerViewModel)
        {
            await repository.AddTeamAnswer(answerViewModel);

            return new TeamAnswerViewModel
            {
                CommandNumber = answerViewModel.CommandNumber,
                QuestionNumber = ++answerViewModel.QuestionNumber,
            };
        }

        public async Task<IEnumerable<TeamAnswerRowViewModel>> GetAnswerRows()
        {
            return await repository.GetAnswerRows();
        }
    }
}

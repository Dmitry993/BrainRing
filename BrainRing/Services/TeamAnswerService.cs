using BrainRing.Interfaces;
using BrainRing.Models;
using BrainRing.ViewModels;

namespace BrainRing.Services
{
    public class TeamAnswerService(ITeamAnswerRepository answerRepository) : ITeamAnswerService
    {
        public async Task<TeamAnswerViewModel> AddTeamAnswer(TeamAnswerViewModel answerViewModel)
        {
            var teamAnswerModel = new TeamAnswer
            {
                CommandNumber = answerViewModel.CommandNumber,
                QuestionNumber = answerViewModel.QuestionNumber,
                Answer = answerViewModel.Answer,
                AnswerTime = TimeOnly.FromDateTime(DateTime.Now)
            };

            await answerRepository.AddTeamAnswer(teamAnswerModel);

            return new TeamAnswerViewModel
            {
                CommandNumber = teamAnswerModel.CommandNumber,
                QuestionNumber = ++teamAnswerModel.QuestionNumber,
            };
        }
    }
}

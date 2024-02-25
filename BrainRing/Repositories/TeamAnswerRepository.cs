using BrainRing.Data.Context;
using BrainRing.Hubs;
using BrainRing.Interfaces;
using BrainRing.Models;
using BrainRing.ViewModels;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace BrainRing.Repositories
{
    public class TeamAnswerRepository(ApplicationContext context,
                                      IHubContext<AnswerHub> hubContext) : ITeamAnswerRepository
    {
        public async Task AddTeamAnswer(TeamAnswerViewModel answerViewModel)
        {
            var answer = new TeamAnswer
            {
                CommandNumber = answerViewModel.CommandNumber,
                QuestionNumber = answerViewModel.QuestionNumber,
                Answer = answerViewModel.Answer,
                AnswerTime = TimeOnly.FromDateTime(DateTime.Now)
            };

            await context.TeamAnswers.AddAsync(answer);
            await context.SaveChangesAsync();

            await hubContext.Clients.All.SendAsync("updateAnswers", answer);
        }

        public async Task<IEnumerable<TeamAnswerRowViewModel>> GetAnswerRows()
        {
            return await context.TeamAnswers
                .OrderBy(answer => answer.QuestionNumber)
                .GroupBy(answer => answer.QuestionNumber)
                .Select(answer => new TeamAnswerRowViewModel
                {
                    QuestionNumber = answer.Key,
                    Cells = answer.Select(cell => new Cell
                    {
                        CommandNumber = cell.CommandNumber,
                        Answer = cell.Answer,
                        AnswerTime = cell.AnswerTime
                    })
                })
                .ToListAsync();
        }
    }
}

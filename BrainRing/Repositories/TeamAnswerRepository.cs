using BrainRing.Data.Context;
using BrainRing.Interfaces;
using BrainRing.Models;

namespace BrainRing.Repositories
{
    public class TeamAnswerRepository(ApplicationContext context) : ITeamAnswerRepository
    {
        public async Task AddTeamAnswer(TeamAnswer answer)
        {
            await context.AddAsync(answer);
            await context.SaveChangesAsync();
        }
    }
}

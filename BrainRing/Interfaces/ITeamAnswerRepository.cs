using BrainRing.Models;

namespace BrainRing.Interfaces
{
    public interface ITeamAnswerRepository
    {
        Task AddTeamAnswer(TeamAnswer answer);
    }
}

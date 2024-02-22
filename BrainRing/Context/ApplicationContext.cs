using BrainRing.Models;
using Microsoft.EntityFrameworkCore;

namespace BrainRing.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TeamAnswer> TeamAnswers { get; set; }
    }
}

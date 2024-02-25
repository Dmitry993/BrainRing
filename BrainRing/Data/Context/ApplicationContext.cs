using BrainRing.Models;
using Microsoft.EntityFrameworkCore;

namespace BrainRing.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
            
            Database.EnsureCreated();
        }

        public DbSet<TeamAnswer> TeamAnswers { get; set; }
    }
}

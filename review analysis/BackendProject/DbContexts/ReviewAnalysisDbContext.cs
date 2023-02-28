using BackendProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.DbContexts
{
    public class ReviewAnalysisDbContext : DbContext
    {
        public ReviewAnalysisDbContext(DbContextOptions<ReviewAnalysisDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Movies> movies { get; set; }
        public DbSet<Food> food { get; set; }
        public DbSet<GeneralProblems> generalProblems { get; set; }
        public DbSet<Politics> politics { get; set; }
        public DbSet<StartupIdeas> startupIdeas  { get; set; }
        public DbSet<Technology> technology { get; set; }
        public DbSet<Universities> universities { get; set;}

        public DbSet<ReviewsData> reviews { get; set; }
    }
}

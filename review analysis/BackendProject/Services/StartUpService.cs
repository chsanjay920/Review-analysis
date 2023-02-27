using BackendProject.DbContexts;
using BackendProject.interfaces;
using BackendProject.Models;

namespace BackendProject.Services
{
    public class StartUpService:IStartUpService
    {
        ReviewAnalysisDbContext dbContext;
        public StartUpService(ReviewAnalysisDbContext dbContext)
        {
           this.dbContext = dbContext;
        }

        public void AddStartUp(StartupIdeas startups)
        {
            startups.QueryId = Guid.NewGuid();
            startups.QueryUploadedAt = DateTime.Now;
            startups.QueryCategory = "StartUps";
            dbContext.startupIdeas.Add(startups);

            dbContext.SaveChanges();
        }

        public List<StartupIdeas> GetStartupIdeas()
        {
            return dbContext.startupIdeas.ToList<StartupIdeas>();   
        }
    }
}

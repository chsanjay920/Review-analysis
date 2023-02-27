using BackendProject.DbContexts;
using BackendProject.interfaces;
using BackendProject.Models;

namespace BackendProject.Services
{
    public class TechnologyService:ITechnologyService
    {
        ReviewAnalysisDbContext dbContext;
        public TechnologyService(ReviewAnalysisDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddTechnologyService(Technology technology)
        {
            technology.QueryId = Guid.NewGuid();
            technology.QueryUploadedAt = DateTime.Now;
            technology.QueryCategory = "Technology";
            dbContext.technology.Add(technology);

            dbContext.SaveChanges();
        }

        public List<Technology> GetTechnologyList()
        {
            return dbContext.technology.ToList<Technology>();
        }
    }
}

using BackendProject.DbContexts;
using BackendProject.interfaces;
using BackendProject.Models;

namespace BackendProject.Services
{
    public class PoliticsService:IPoliticsService
    {
        ReviewAnalysisDbContext dbContext;
        public PoliticsService(ReviewAnalysisDbContext dbContext) {
            this.dbContext = dbContext; 
        }

        public void AddPolitics(Politics politics)
        {
            politics.QueryId = Guid.NewGuid();
            politics.QueryUploadedAt = DateTime.Now;
            politics.QueryCategory = "Politics";
            dbContext.politics.Add(politics);

            dbContext.SaveChanges();
        }

        public List<Politics> GetPolitics()
        {
            return dbContext.politics.ToList<Politics>();
        }
    }
}

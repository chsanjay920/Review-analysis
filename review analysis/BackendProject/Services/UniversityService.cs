using BackendProject.DbContexts;
using BackendProject.interfaces;
using BackendProject.Models;

namespace BackendProject.Services
{
    public class UniversityService:IUniversityService
    {
        ReviewAnalysisDbContext dbContext1;
        public UniversityService(ReviewAnalysisDbContext dbContext) {
            this.dbContext1 = dbContext;
        }

        public void AddUniversityService(Universities universities)
        {
            universities.QueryId = Guid.NewGuid();
            universities.QueryUploadedAt = DateTime.Now;
            universities.QueryCategory = "Universities";
            dbContext1.universities.Add(universities);
            dbContext1.SaveChanges();
        }

        public List<Universities> GetUniversidsties()
        {
            return dbContext1.universities.ToList();
        }
    }
}

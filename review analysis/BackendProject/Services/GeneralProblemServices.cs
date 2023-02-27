using BackendProject.DbContexts;
using BackendProject.interfaces;
using BackendProject.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BackendProject.Services
{
    public class GeneralProblemServices : IGeneralProblemService
    {
        ReviewAnalysisDbContext dbContext;
        public GeneralProblemServices(ReviewAnalysisDbContext dbContext) {
            this.dbContext = dbContext;
        } 
        public void addGeneralProblem(GeneralProblems generalProblems)
        {
            generalProblems.QueryId = Guid.NewGuid();
            generalProblems.QueryUploadedAt = DateTime.Now;
            generalProblems.QueryCategory = "GeneralProblems";
            dbContext.generalProblems.Add(generalProblems);

            dbContext.SaveChanges();
        }

        public List<GeneralProblems> GetGeneralproblems()
        {
            return dbContext.generalProblems.ToList<GeneralProblems>();
        }
    }
}

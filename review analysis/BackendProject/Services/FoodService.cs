using BackendProject.DbContexts;
using BackendProject.interfaces;
using BackendProject.Models;

namespace BackendProject.Services
{
    public class FoodService : IFoodService
    {
        ReviewAnalysisDbContext dbContext;
        public FoodService(ReviewAnalysisDbContext dbContext) {
            this.dbContext = dbContext;
        }
        public void addFoodData(Food f)
        {
            f.QueryId = Guid.NewGuid();
            f.QueryUploadedAt = DateTime.Now;
            f.QueryCategory = "Food";
            dbContext.food.Add(f);
            dbContext.SaveChanges();
        }

        public List<Food> getFoodData()
        {
           return dbContext.food.ToList<Food>();
        }
    }
}

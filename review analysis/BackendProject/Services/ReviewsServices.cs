using BackendProject.DbContexts;
using BackendProject.interfaces;
using BackendProject.Models;
using System.Diagnostics;

namespace BackendProject.Services
{
    public class ReviewsServices : IReviewsServices
    {
        public ReviewAnalysisDbContext database;
        public ReviewsServices(ReviewAnalysisDbContext database) {
            this.database = database;
        }
        public void AddReview(ReviewsData reviewdata)
        {
            this.database.reviews.Add(reviewdata);
            this.database.SaveChanges();
        }
        public List<ReviewsData> GetReviews(Guid guid)
        {
            return this.database.reviews.Where(m=>m.QueryID == guid).ToList<ReviewsData>();
        }
    }
}

using BackendProject.Models;

namespace BackendProject.interfaces
{
    public interface IReviewsServices
    {
        public void AddReview(ReviewsData reviewdata);
        public List<ReviewsData> GetReviews(Guid guid);
    }
}

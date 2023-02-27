using BackendProject.Models;

namespace BackendProject.interfaces
{
    public interface IFeedService
    {
        public List<FeedData> GetAllQueries();
    }
}

using BackendProject.DbContexts;
using BackendProject.interfaces;
using BackendProject.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BackendProject.Services
{
    public class MoviesService : IMoviesService
    {
        ReviewAnalysisDbContext dbContext;
        public MoviesService(ReviewAnalysisDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Addmovies(Movies movies)
        {
            movies.QueryId = Guid.NewGuid();
            movies.QueryUploadedAt = DateTime.Now;
            movies.QueryCategory = "Movies";
            dbContext.movies.Add(movies);
            dbContext.SaveChanges();
        }
        public List<Movies> GetMovies()
        {
            return dbContext.movies.ToList();
        }
    }
}

using BackendProject.Models;

namespace BackendProject.interfaces
{
    public interface IMoviesService
    {
        public void Addmovies(Movies movies);
        public List<Movies> GetMovies();
    }
}

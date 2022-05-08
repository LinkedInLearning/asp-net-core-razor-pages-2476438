using MoviesApp.Data.Models;

namespace MoviesApp.Services
{
    public interface IMoviesService
    {
        List<Movie> GetAll();
        Movie? Get(int id);
        void Add(Movie movie);
    }
}

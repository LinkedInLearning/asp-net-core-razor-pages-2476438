using MoviesApp.Data;
using MoviesApp.Data.Models;

namespace MoviesApp.Services
{
    public class MoviesService : IMoviesService
    {
        private ApplicationDbContext _context;
        public MoviesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public Movie? Get(int id) => _context.Movies.FirstOrDefault(x => x.Id == id);

        public List<Movie> GetAll() => _context.Movies.ToList();
        
    }
}

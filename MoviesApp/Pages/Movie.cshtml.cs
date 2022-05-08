using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data;
using MoviesApp.Data.Models;

namespace MoviesApp.Pages
{
    public class MovieModel : PageModel
    {
        public Movie? Movie { get; set; }


        private ApplicationDbContext _context;
        public MovieModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Movie = _context.Movies.FirstOrDefault(n => n.Id == id);
        }
    }
}

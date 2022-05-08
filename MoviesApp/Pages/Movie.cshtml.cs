using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data;
using MoviesApp.Data.Models;
using MoviesApp.Services;

namespace MoviesApp.Pages
{
    public class MovieModel : PageModel
    {
        public Movie? Movie { get; set; }


        private IMoviesService _service;
        public MovieModel(IMoviesService service)
        {
            _service = service;
        }

        public void OnGet(int id)
        {
            Movie = _service.Get(id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data;
using MoviesApp.Data.Models;
using MoviesApp.Services;

namespace MoviesApp.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }

        private IMoviesService _service;
        public MoviesModel(IMoviesService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Movies = _service.GetAll();
        }
    }
}

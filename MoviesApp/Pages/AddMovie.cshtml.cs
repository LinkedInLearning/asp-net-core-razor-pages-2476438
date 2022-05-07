using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data.Models;

namespace MoviesApp.Pages
{
    public class AddMovieModel : PageModel
    {
        //[BindProperty]
        //public string Title { get; set; }

        //[BindProperty]
        //public int Rate { get; set; }

        //[BindProperty]
        //public string Description { get; set; }

        [BindProperty]
        public Movie Movie { get; set; }

        //public void OnGetMyOnClick()
        //{
        //    string stopHere = "";
        //}

        public void OnGet()
        {
            // Title = "Welcome";
        }

        public IActionResult OnPost()
        {
            //string value = $"{Title} - {Rate} - {Description}";
            string value = $"{Movie.Title} - {Movie.Rate} - {Movie.Description}";

            return Page();
            //return Redirect("Movies");
        }
    }
}

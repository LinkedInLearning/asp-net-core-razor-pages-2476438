using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data.Models;

namespace MoviesApp.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }

        public void OnGet()
        {
            Movies = new List<Movie>()
            {
                new Movie() {
                    Id = 1,
                    Title = "First movie title",
                    Rate = 10,
                    Description = "First movie description goes here..."
                },new Movie() {
                    Id = 2,
                    Title = "Second movie title",
                    Rate = 7,
                    Description = "Second movie description goes here..."
                }, new Movie() {
                    Id = 3,
                    Title = "Third movie title",
                    Rate = 5,
                    Description = "Third movie description goes here..."
                }, new Movie() {
                    Id = 4,
                    Title = "Forth movie title",
                    Rate = 10,
                    Description = "Forth movie description goes here..."
                }
            };
        }
    }
}

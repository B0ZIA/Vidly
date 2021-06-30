using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly List<Movie> movies = new List<Movie>
        {
            new Movie { Name = "Shrek", Id = 1},
            new Movie { Name = "Wall-e", Id = 2}
        };

        public ActionResult All()
        {
            var viewModel = new AllMovieViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        public ActionResult One(int id)
        {
            Movie movie = movies.First(p => p.Id == id);

            if (movie == null)
                return new HttpNotFoundResult();
            else
                return View(movie);
        }
    }
}
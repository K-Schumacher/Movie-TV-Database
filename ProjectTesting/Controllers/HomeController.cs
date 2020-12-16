using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectTesting.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTesting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var movie = new MovieModel();
            return View();
        }

        public IActionResult Search(string movieTitle)
        {
            var repo = new MovieRepository();
            var movies = repo.GetMovies(movieTitle);

            ViewData["userInput"] = movieTitle;

            return View(movies);
        }
        public IActionResult ViewMovie(string movieTitle, string imdbID)
        {
            var repo = new MovieRepository();
            var movies = repo.GetMovies(movieTitle);
            var movie = new MovieModel();

            foreach (var mov in movies)
            {
                if (mov.imdbID == imdbID)
                {
                    movie = mov;
                }
            }
            return View(movie);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

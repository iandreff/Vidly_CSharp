using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController() => _context = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        

        // GET: movies/random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Sherek" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1" },
                new Customer {Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel); //view() will render the html under folder Movie/Random.cshtml
                                    // If pass the movie model as a argument of View() it render the object "movie" inside Random
        }
        
        // GET: movies/index
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(g => g.Genre).ToList();

            return View(movies);
        }

        // GET: movies/detail
        public ActionResult Detail(int id)
        {
            var movie = _context.Movies.Include(g => g.Genre).SingleOrDefault(g => g.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie); //this is the Model
        }


    }
}
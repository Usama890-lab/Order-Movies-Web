using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidlyWeb.Data;
using VidlyWeb.Models;
using VidlyWeb.ViewModels;

namespace VidlyWeb.Controllers
{
    public class MoviesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies.Include(g => g.Genre).ToListAsync();

            return View(movies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movie = await _context.Movies.Include(g => g.Genre).SingleOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }


        public async Task<IActionResult> New()
        {
            var genres = await _context.Genres.ToListAsync();
            var viewModel = new MovieFormViewModel
            {
                Genres = genres,
                Movie = new Movie()
            };

            return View("MovieForm", viewModel);

        }


        public async Task<IActionResult> Edit(int id)
        {
            var movie = await _context.Movies.SingleOrDefaultAsync(c => c.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            var viewModel = new MovieFormViewModel
            {
                Genres = await _context.Genres.ToListAsync(),
                Movie = movie
            };

            return View("MovieForm", viewModel);
        }

        public IActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };


            return View(viewModel);
        }


        public IActionResult Save(Movie movie)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }
            if (movie.Id == 0)
            {
                movie.InventoryDate = DateTime.Now;
                _context.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Cancel()
        {
            return RedirectToAction("Index");

        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidlyWeb.Data;
using VidlyWeb.Models;

namespace VidlyWeb.Controllers
{
    public class GenresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GenresController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var genres = _context.Genres.ToList();

            return View(genres);
        }

        
        public IActionResult Add()
        {
            var genre = new Genre();
            return View("GenreForm", genre);

        }

        [HttpPost]
        public IActionResult Save(Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View("GenreForm");
            }
            if (genre.Id == 0)
            {
                _context.Genres.Add(genre);
                _context.SaveChanges();
            }
           
            return RedirectToAction("Index");
        }


        public IActionResult Cancel()
        {
            return RedirectToAction("Index");
        }
    }
}

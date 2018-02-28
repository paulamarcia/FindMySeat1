using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FindMySeat1.Controllers
{
    public class MovieController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            List<string> movies = new List<string>();

            movies.Add("Black Panther");
            movies.Add("Annihilation");
            movies.Add("Game Night");
            movies.Add("Fifty Shades Freed");
            movies.Add("Peter Rabbit");
            movies.Add("Jumanji: Welcome to the Jungle");


            ViewBag.movies = movies;



            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}

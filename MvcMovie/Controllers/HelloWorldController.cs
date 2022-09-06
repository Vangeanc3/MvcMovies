using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        private readonly MvcMovieContext _context;

        public HelloWorldController(MvcMovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //var video = new Movie();

            //ViewData["hoje"] = video.ReleaseDate;

            ViewData["titulo"] = _context.Movies;

            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}

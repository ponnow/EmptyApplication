using ContactUsApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactUsApplication.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(Movie movie)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }
}

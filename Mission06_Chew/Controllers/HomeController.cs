using Microsoft.AspNetCore.Mvc;
using Mission06_Chew.Models;
using System.Diagnostics;

namespace Mission06_Chew.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _context;

        public HomeController(MovieApplicationContext temp) //Constructor
        {
            _context = temp;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View("AddMovie");
        }

        [HttpPost]
        public IActionResult Confirmation(Application response)
        {
            _context.Application.Add(response); // add record to database
            _context.SaveChanges();
            
            return View("Confirmation", response);
        }
    }
}

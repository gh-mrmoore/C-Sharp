using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unit04_Prep.Controllers
{
    public class ExercisesController : Controller
    {
        private static Dictionary<string, string> Locations = new Dictionary<string, string>();
        string startingLocation = "Kansas City";
        string startingCity = "KS";

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.locations = Locations;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route ("/Exercises/Add")]
        public IActionResult ProcessLocation(string cityname, string statename)
        {
            Locations.Add(cityname, statename);

            return Redirect("/Exercises");
        }
    }
}

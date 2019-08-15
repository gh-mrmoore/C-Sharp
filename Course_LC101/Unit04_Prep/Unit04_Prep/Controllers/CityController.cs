using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unit04_Prep.Controllers
{
    public class CityController : Controller
    {
        static private List<string> Cities = new List<string>();
        //static - property available to any code in the class - doesn't belong to any one instance

        // GET: /<controller>/
        public IActionResult Index()
        {
            //data moved over from template, still no database persistence
            /*List<string> cities = new List<string>();

            cities.Add("New York City");
            cities.Add("London");
            cities.Add("Kansas City");
            cities.Add("Topeka");
            */

            //ViewBag.cities = cities;
            ViewBag.cities = Cities;  //capitalized as it's not a local variable

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/City/Add")]
        public IActionResult Process(string cityname)
        {
            //add to our existing list
            Cities.Add(cityname);

            return Redirect("/City");
        }
    }
}

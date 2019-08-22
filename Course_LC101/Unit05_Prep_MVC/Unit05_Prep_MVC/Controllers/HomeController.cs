using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unit05_Prep_MVC.Models;

namespace Unit05_Prep_MVC.Controllers
{
    public class HomeController : Controller
    {
        private static int animalId = 1;
        private static Dictionary<int, Dogs> Animals = new Dictionary<int, Dogs>();

        public IActionResult Index()
        {
            ViewBag.dogs = Animals;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Home/Add")]
        public IActionResult ProcessAdd(String dogbreed, String dogsize)
        {
            if (String.IsNullOrWhiteSpace(dogbreed) || String.IsNullOrWhiteSpace(dogsize))
            {
                return Redirect("/Home/Add");
            }
            else
            {
                //create the new Dogs object for the current dog being added
                Dogs currentDog = new Dogs(dogbreed, dogsize);

                //add the dog object and the unique counter to the dictionary being used
                //in lieu of a database
                Animals.Add(animalId, currentDog);

                //increment the ID to avoid duplicate keys
                animalId++;

                return Redirect("/Home");
            }
        }
        
        [HttpPost]
        public IActionResult DeleteMany(string[] deletedogs)
        {

            foreach (string dog in deletedogs)
            {
                int dogKey = Int32.Parse(dog);
                Animals.Remove(dogKey);
            }

            return Redirect("/Home");
        }
        /*
        [HttpPost]
        public IActionResult DeleteOne(string onedog)
        {
            Animals.Remove(onedog);

            return Redirect("/Home");
        }
        */
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

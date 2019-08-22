using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unit04_Studio.Models;

namespace Unit04_Studio.Controllers
{
    public class HomeController : Controller
    {
        private static Dictionary<string, string> Dogs = new Dictionary<string, string>();

        public IActionResult Index()
        {
            ViewBag.dogs = Dogs;
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
            } else
            {
                Dogs.Add(dogbreed, dogsize);

                return Redirect("/Home");
            }
        }

        [HttpPost]
        public IActionResult DeleteMany(string[] deletedogs)
        {
            
            foreach (string dog in deletedogs)
            {
                Dogs.Remove(dog);
            }
            
            return Redirect("/Home");
        }

        [HttpPost]
        public IActionResult DeleteOne(string onedog)
        {
            Dogs.Remove(onedog);

            return Redirect("/Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

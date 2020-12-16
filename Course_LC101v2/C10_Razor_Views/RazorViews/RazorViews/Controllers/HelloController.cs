using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RazorViews.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            List<string> dogBreeds = new List<string>();
            dogBreeds.Add("Dalmation");
            dogBreeds.Add("Poodle");
            dogBreeds.Add("Great Dane");
            dogBreeds.Add("Yorkshire Terrier");

            List<string> dogInfo = new List<string>();
            dogInfo.Add("Canus Familiaris");
            dogInfo.Add("Good dog!");

            Dog dalmation = new Dog("Dalmation", "Medium", dogInfo);
            Dog poodle = new Dog("Poodle", "Medium", dogInfo);
            Dog greatDane = new Dog("Great Dane", "Large", dogInfo);
            Dog yorkie = new Dog("Yorkshire Terrier", "Small", dogInfo);

            List<Dog> dogObjects = new List<Dog>();
            dogObjects.Add(dalmation);
            dogObjects.Add(poodle);
            dogObjects.Add(greatDane);
            dogObjects.Add(yorkie);

            ViewBag.puppyObjects = dogObjects;
            ViewBag.puppies = dogBreeds;

            return View();
        }
    }

    public class Dog
    {
        // fields and/or properties
        public string breedName { get; set; }
        public string breedSize { get; set; }
        public List<string> breedInfo { get; set; }

        // contructor(s)
        public Dog(string bName, string bSize, List<string> bInfo)
        {
            breedName = bName;
            breedSize = bSize;
            breedInfo = bInfo;
        }

    }
}

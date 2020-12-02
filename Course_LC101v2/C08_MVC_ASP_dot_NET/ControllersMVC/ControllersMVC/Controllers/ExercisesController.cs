using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControllersMVC.Controllers
{
    public class ExercisesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string exerciseHtml = "<h1>Exercises</h1>" +
                "<form method='post' action='exercise2/'>" +
                "<label for='name'>Your Name:</label><br />" +
                "<input type='text' name='name' id='name' /><br />" +
                "<label for='language'>Select Language</label><br />" +
                "<select name='language' id='language'>" +
                "<option value='english'>English</option>" +
                "<option value='french'>French</option>" +
                "<option value='german'>German</option>" +
                "<option value='spanish'>Spanish</option>" +
                "<option value='aussie'>Australian</option>" +
                "</select><br />" +
                "<input type='submit' value='Greet Me' />" +
                "</form>";
            return Content(exerciseHtml, "text/html");
        }

        [HttpPost]
        [Route("/exercises/exercise2/")]
        public IActionResult FormResponse(string name, string language)
        {
            string responseString;
            if(language == "english")
            {
                responseString = "Hello " + name;
            } else if(language == "french") 
            {
                responseString = "Bonjour " + name;
            } else if(language == "german")
            {
                responseString = "Guten tag " + name;
            } else if(language == "spanish")
            {
                responseString = "Hola " + name;
            } else
            {
                responseString = "G'day " + name;
            }

            return Content(responseString, "text/html");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControllersMVC.Controllers
{
    // can add routing here to override path for entire controller
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloform'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/helloform/")]
        public IActionResult FormProcessor(string name)
        {
            string formWelcome = "<h1>Welcome to the form controller " + name + "!";
            return Content(formWelcome, "text/html");
        }

        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
        public IActionResult Welcome(string name = "World")
        {
            if(name != "World")
            {
                string welcomeReturn = "<h1>Form</h1>";
                return Content(welcomeReturn, "text/html");
            } else
            {
                string stringNotForm = "<h1>Not Form</h1>";
                return Content(stringNotForm, "text/html");
            }
        }
    }
}

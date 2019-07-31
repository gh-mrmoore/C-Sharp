using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unit03_Prep.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("Hello World");
        }

        //route is hello/test
        //altering the route - this unbinds the 'hello/test' route that would otherwise be default
        [Route("/hello/goodbye")]
        public IActionResult Test()
        {
            return Content("<h1>Hello Test!</h1>", "text/html");
        }

        public IActionResult Test2()
        {
            string test2Html = "<h1>Hello Test 2!</h1>";
            return Content(test2Html, "text/html");
        }

        //add the ability to recognize a querystring
        public IActionResult Qstring(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Blank";
            }
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        //use querystring but assign default in method signature - removes need for condition in method above
        public IActionResult Qstring2(string name = "blank2")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        //using and responding to forms
        public IActionResult FormDisplay()
        {
            string formHTML = "<form method='post' action='/Hello/FormResponse'>" +
                "<input type='text' name='name' id='name' />" +
                "<input type='submit' value='Submit' />" +
                "</form>";
            return Content(formHTML, "text/html");
        }
        public IActionResult FormResponse(string name = "blank3")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        //post to the same URL as the form is displayed at
        [Route("/TestForm2")]
        [HttpGet]
        public IActionResult FormDisplay2()
        {
            string form2HTML = "<form method='post'>" +
                "<p>Please enter your name below.</p>" +
                "<input type='text' name='username' id='username' />" +
                "<input type='submit' value='Go' />" +
                "</form>";
            return Content(form2HTML, "text/html");
        }

        [Route("/TestForm2")]
        [HttpPost]
        public IActionResult FormResponse2(string username = "Blank4")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", username), "text/html");
        }
    }
}

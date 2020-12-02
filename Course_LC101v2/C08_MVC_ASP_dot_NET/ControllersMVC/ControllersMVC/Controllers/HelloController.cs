using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControllersMVC.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            string pageHtml = "<h1>Hello Controller!</h1>";
            return Content(pageHtml, "text/html");
        }

        [HttpGet]
        [Route("/helloworld/")]
        public IActionResult WorldIndex()
        {
            string helloHtml = "<h1>Hello World!</h1>";
            return Content(helloHtml, "text/html");
        }

        [HttpGet]
        [Route("/helloname/{name?}")]
        public IActionResult NameIndex(string name = "World")
        {
            string combined = "<h1>Welcome " + name + " to ASP.NET Core";
            return Content(combined, "text/html");
        }
    }
}

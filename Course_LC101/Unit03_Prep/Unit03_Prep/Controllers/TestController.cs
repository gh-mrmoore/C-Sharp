using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unit03_Prep.Controllers
{
    public class TestController : Controller
    {
        // handle URL segments
        [Route("/Test/{name}")]
        public IActionResult Index(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        //redirect from a request
        public IActionResult Hello()
        {
            return Redirect("/Hello");
        }
    }
}

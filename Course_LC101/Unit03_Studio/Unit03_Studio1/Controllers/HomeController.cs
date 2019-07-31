using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unit03_Studio1.Models;

namespace Unit03_Studio1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string formHTML = "<form method='post' action='/Home/FormResponse'>" +
                "<input type='text' name='name' id='name' />" +
                "<select name='language'>" +
                "<option value='ES'>Spanish</option>" +
                "<option value='FR'>French</option>" +
                "<option value='GR'>German</option>" +
                "<option value='PR'>Portuguese</option>" +
                "<option value='AU'>Australian</option>" +
                "<input type='submit' value='Submit' />" +
                "</form>";
            return Content(formHTML, "text/html");
        }
        public IActionResult FormResponse(string name = "blank_default", string language = "EN")
        {
            string greeting = "Hello";
            if (language == "ES")
            {
                greeting = "Hola";
            }
            else if (language == "FR")
            {
                greeting = "Bonjour";
            }
            else if (language == "GR")
            {
                greeting = "Guten Tag";
            }
            else if (language == "PR")
            {
                greeting = "Ola";
            }
            else if (language == "AU")
            {
                greeting = "G'Day";
            }
            return Content(string.Format("<p><span style='font-style: italic'>{0}</span> {1}</h1>", greeting, name), "text/html");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

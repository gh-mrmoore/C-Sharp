using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControllersMVC.Controllers
{
    [Route("/skills/")]
    public class StudioController : Controller
    {
        public IActionResult Index()
        {
            string studioWelcome = "<h1>Welcome to the Studio</h1>" +
                "<h2>Skills Tracker</h2>" +
                "<h3>Coding skills to learn:" +
                "<ol>" +
                "<li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li>" +
                "</ol>" +
                "<p><a href='/skills/form/'>Skills Update Form</a></p>";
            return Content(studioWelcome, "text/html");
        }

        [Route("form")]
        public IActionResult SkillForm()
        {
            string studioForm = "<h1>Update Your Skills</h1>" +
                "<form method='post' action='/skills/process'>" +
                "<label for='date'>Date:</label><br />" +
                "<input type='date' name='date' id='date' /><br />" +
                "<label for='csharp'>C#</label><br />" +
                "<select name='csharp' id='csharp'>" +
                    "<option value='Learning basics'>Learning Basics</option>" +
                    "<option value='Making apps'>Making Apps</option>" +
                    "<option value='Expert'>Expert</option>" +
                "</select><br />" +
                "<label for='javascript'>JavaScript</label><br />" +
                "<select name='javascript' id='javascript'>" +
                    "<option value='Learning basics'>Learning Basics</option>" +
                    "<option value='Making apps'>Making Apps</option>" +
                    "<option value='Expert'>Expert</option>" +
                "</select><br />" +
                "<label for='python'>Python</label><br />" +
                "<select name='python' id='python'>" +
                    "<option value='Learning basics'>Learning Basics</option>" +
                    "<option value='Making apps'>Making Apps</option>" +
                    "<option value='Expert'>Expert</option>" +
                "</select><br />" +
                "<input type='submit' value='Update Skills' />";
            return Content(studioForm, "text/html");
        }

        [Route("process")]
        public IActionResult ProcessSkills(string date, string csharp, string javascript, string python)
        {
            string processString = "<h1>Skill Tracker Update" +
                "<h2>My coding skills:</h2>" +
                "<p>As of " + date + "</p>" +
                "<ol>" +
                "<li>C# " + csharp + "</li>" +
                "<li>JavaScript " + javascript + "</li>" +
                "<li>Python " + python + "</li>" +
                "</ol>";

            return Content(processString, "text/html");
        }
    }
}

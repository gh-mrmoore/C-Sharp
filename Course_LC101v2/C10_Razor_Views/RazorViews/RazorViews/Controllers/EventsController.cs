using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RazorViews.Controllers
{
    public class EventsController : Controller
    {
        static private List<string> codingEvents = new List<string>();
        static private Dictionary<string, string> codingEventsDictionary = new Dictionary<string, string>();

        [HttpGet]
        public IActionResult Index()
        {
            // codingEvents.Add("Meetup");
            // codingEvents.Add("Conference");
            // codingEvents.Add("Speech");
            // codingEventsDictionary.Add("Conference", "Annual Tech Conference");

            ViewBag.eventList = codingEventsDictionary;
            return View();
        }

        [HttpPost]
        [Route("/Events")]
        public IActionResult AddEvent(string eventName,string eventDescription)
        {
            // codingEvents.Add(eventName);
            codingEventsDictionary.Add(eventName, eventDescription);
            return Redirect("/Events");
        }
    }
}

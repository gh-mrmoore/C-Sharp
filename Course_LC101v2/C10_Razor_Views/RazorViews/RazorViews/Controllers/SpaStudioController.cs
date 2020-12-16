﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RazorViews.Controllers
{
    public class SpaStudioController : Controller
    {
        public bool CheckSkinType(string skinType, string facialType)
        {

            if (facialType != "Microdermabrasion")
            {
                if (skinType == "oily" && facialType != "Rejuvenating")
                {
                    return false;
                }
                else if (skinType == "combination" && (facialType != "Rejuvenating" || facialType != "Enzyme Peel"))
                {
                    return false;
                }
                else if (skinType == "dry" && facialType != "Hydrofacial")
                {
                    return false;
                }
            }

            return true;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/spastudio")]
        public IActionResult Menu(string name, string skintype, string manipedi)
        {
            List<string> facials = new List<string>()
            {
                "Microdermabrasion", "Hydrofacial", "Rejuvenating", "Enzyme Peel"
            };

            List<string> appropriateFacials = new List<string>();
            for (int i = 0; i < facials.Count; i++)
            {
                if (CheckSkinType(skintype, facials[i]))
                {
                    appropriateFacials.Add(facials[i]);
                }
            }

            ViewBag.name = name;
            ViewBag.skinType = skintype;
            ViewBag.facials = appropriateFacials;
            ViewBag.manipedi = manipedi;

            return View();
        }


    }
}
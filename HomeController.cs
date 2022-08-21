using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20428155_HW04.Models;

namespace u20428155_HW04.Controllers
{
    public class HomeController : Controller
    {
        public static List<Volunteer> volunteers = new List<Volunteer>();
        public ActionResult Home()
        {
            return View("Breadline Africa - South Africa is a Non-Profit organisation that aims to try help those struggling with hunger by reaching out " +
                " to Schools and Communitys. It also goes out and requests the help of retail stores to help out. Volunteers are always to help out where they can. ");
        }

    [HttpGet]
        public ActionResult Districts()
        {
            ViewBag.Message = "Supported Districts";
            return View();
        }

        public ActionResult Schools()
        {
            ViewBag.Message = "Supported Schools";
            return View();
        }

        public ActionResult Stores()
        {
            ViewBag.Message = "Supporting Stores";
            return View();
        }

        public ActionResult AddVolunteer()
        {
            Volunteer volunteers = new Volunteer()
            {
               
            };

            Volunteer.Add(volunteers);
            return (Volunteer);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Breadline Africa - South Africa contact page." ;

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // GET /home/index
            return View();
        }

        // GET /home/about
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Foo to be an ailias to the about page. 
        public ActionResult Foo()
        {
            return View("About"); 
        }

        //Returns the serial number of the atm with serial number route
        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5ATM1"; 

            if (letterCase == "lower")
            {
                return Content(serial.ToLower()); 
            }
            return Content(serial); 
        }
    }
}
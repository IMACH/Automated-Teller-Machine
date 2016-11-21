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
        //Use this if you want the urp to display with dashes, this will look for the view with this name (about-this-atm)
        [ActionName("about-this-atm")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //Instead you can still pass the About video into the View method. 
            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            //TODO : send message to HQ
            ViewBag.TheMessage = "Thanks, we got your message!";

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
            //ContentRequest
            //return Content(serial);

            //Json Request
            //return Json(new { name = "serial", value = serial },
            //JsonRequestBehavior.AllowGet); 

            //RedirectToActionRequest
            return RedirectToAction("Index");

        }
    }
}
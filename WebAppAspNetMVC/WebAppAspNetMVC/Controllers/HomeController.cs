using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppAspNetMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Is it you Snuggles?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here's how you can connect with Snuggles.";

            return View();
        }
    }
}
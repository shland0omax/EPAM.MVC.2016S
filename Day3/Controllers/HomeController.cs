using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewBag.Message = "hELLO, world!";
            //ViewBag.Time = DateTime.Now;
            //return View("Custom");
            var names = new string[] {"Apples", "Orange", "Pear"};
            return View(names);
        }

        public ActionResult List()
        {
            return View();
        }
    }
}
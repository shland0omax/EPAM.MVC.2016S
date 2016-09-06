using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult AnotherAction()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3_HomeTask.Infrastructure;
using Day3_HomeTask.Models;

namespace Day3_HomeTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Person", UserRepository.GetPerson());
        }
        
        [ChildActionOnly]
        [HttpGet]
        public ActionResult ChangeSide()
        {
            return PartialView("_ChangeSide");
        }

        [ActionName("ChangeSide")]
        [HttpPost]
        public ActionResult ChangeSidePost()
        {
            var p = UserRepository.GetPerson();
            p.IsDarkSided = !p.IsDarkSided;
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2.HomeTask.Infrastructure;

namespace Day2.HomeTask.Controllers
{
    //manage users list, only local access
    public class AdminController : Controller
    {
        [Local]
        public ActionResult Index()
        {
            return View();
        }
    }
}
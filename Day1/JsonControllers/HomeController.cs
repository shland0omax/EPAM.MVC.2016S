using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1.JsonControllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public JsonResult Index(int? id)
        {
            if (id == null) id = 0;
            return Json(id, JsonRequestBehavior.AllowGet) ;
        }
    }
}
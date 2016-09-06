using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using Day2.Infrastructure;
using Day2.Models;

namespace Day2.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Customer",
                ActionName = "Index"
            });
        }

        [Local]
        [ActionName("Index")]
        public ActionResult LocalIndex()
        {
            return View("Result", new Result
            {
                ControllerName = "Customer",
                ActionName = "LocalIndex"
            });
        }

        public ActionResult List()
        {
            return View("Result", new Result
            {
                ControllerName = "Customer",
                ActionName = "List"
            });
        }

        //public CustomerController()
        //{
        //    this.ActionInvoker = new CustomActionInvoker();
        //}
    }
}
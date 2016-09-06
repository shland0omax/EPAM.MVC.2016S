

using System.Web.Mvc;

namespace AsideControllers
{
    public class HomeController: Controller
    {
        public JsonResult Index(int? id)
        {
            if (id == null) id = 0;
            return Json(id, JsonRequestBehavior.AllowGet);
        }
    }
}
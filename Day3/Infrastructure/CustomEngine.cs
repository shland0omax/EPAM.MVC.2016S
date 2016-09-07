using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day3.Infrastructure
{
    public class CustomEngine: IViewEngine
    {
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            throw new NotImplementedException();
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (viewName == "CustomData")
            {
                return new ViewEngineResult(new CustomView(), this);
            }
            else
            {
                return new ViewEngineResult(new string[]
                {
                    "No view (CustoViewEngine)"
                });
            }
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
            throw new NotImplementedException();
        }
    }
}
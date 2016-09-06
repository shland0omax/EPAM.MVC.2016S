using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Day2.Controllers;

namespace Day2.Infrastructure
{
    public class CustomControllerFactory: IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type targeType = null;

            switch (controllerName)
            {
                case "Product":
                    targeType = typeof (ProductController);
                    break;
                case "Customer":
                    targeType = typeof (CustomerController);
                    break;
                default:
                    requestContext.RouteData.Values["controller"] = "Product";
                    targeType = typeof (ProductController);
                    break;
            }
            return targeType == null ? null : (IController) DependencyResolver.Current.GetService(targeType);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return  SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            disposable?.Dispose();
        }
    }
}
using System;
using System.Web.Mvc;
using System.Web.Routing;
using Day2.Controllers;

namespace Day2.Infrastructure
{
    public class CustomControllerActivator: IControllerActivator
    {
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == typeof (ProductController))
            {
                controllerType = typeof (CustomerController);
            }
            return (IController) DependencyResolver.Current.GetService(controllerType);
        }
    }
}
using System.Web.Routing;
using Machine.Specifications;

namespace Day1.Tests
{
    [Subject("Routing")]
    public class SuccessRoutingTest
    {
        static RouteCollection routes;
        static bool value;
        static string url;

        Establish context = () =>
        {
            routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            url = "~/Constraints/Custom/CustomVariableWithConstraints/1001";
        };

        Because of = () =>
        {
            value = routes.GetRouteData(Mocking.CreateHttpContext(url))?.Route != null;
        };

        It fails = () => value.ShouldBeFalse();
    }

    [Subject("Routing")]
    public class UnsuccessRoutingTest
    {
        static RouteCollection routes;
        static RouteData result;
        static string url;
        static string controller;
        static string action;
        static string routeProperties;

        Establish context = () =>
        {
            routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            url = "~/Constraints/Custom/CustomVariableWithConstraints/1000";
            controller = "Custom";
            action = "CustomVariableWithConstraints";
            routeProperties = null;
        };

        Because of = () => result = routes.GetRouteData(Mocking.CreateHttpContext(url));

        It should_pass = () => result.ShouldNotBeNull();
        It should_also_pass = () => Mocking.TestIncomingRouteResult(result, controller, action, routeProperties).ShouldBeTrue();

    }
}
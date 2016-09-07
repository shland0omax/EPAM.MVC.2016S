using System;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Routing;
using Moq;

namespace Day1.Tests
{
    public static class TestHelper
    {
        public static HttpContextBase CreateHttpContext(string url = null, string httpMethod = "GET")
        {
            var mockRequest = new Mock<HttpRequestBase>();
            mockRequest.Setup(m => m.AppRelativeCurrentExecutionFilePath).Returns(url);
            mockRequest.Setup(m => m.HttpMethod).Returns(httpMethod);

            var mockResponse = new Mock<HttpResponseBase>();
            mockResponse.Setup(m => m.ApplyAppPathModifier(It.IsAny<string>())).Returns<string>(s => s);

            var mockContext = new Mock<HttpContextBase>();
            mockContext.Setup(m => m.Request).Returns(mockRequest.Object);
            mockContext.Setup(m => m.Response).Returns(mockResponse.Object);

            return mockContext.Object;
        }

        public static bool TestIncomingRouteResult(RouteData res, string controller, string action,
            object propertySet = null)
        {
            Func<object, object, bool> varCompare = (v1, v2) => StringComparer.InvariantCultureIgnoreCase.Compare(v1, v2) == 0;

            bool result = varCompare(res.Values["controller"], controller) 
                && varCompare(res.Values["action"], action);

            if (propertySet != null)
            {
                PropertyInfo[] info = propertySet.GetType().GetProperties();
                if (info.Any(i => !(res.Values.ContainsKey(i.Name)
                                    && varCompare(res.Values[i.Name], i.GetValue(propertySet, null)))))
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
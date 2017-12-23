using Apex.ConnectApi;
using Apex.System;
using NUnit.Framework;

namespace ApexTest.System
{
    [TestFixture]
    public class RestContextTests
    {
        [Test]
        public void RestRequestIsImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var request = new RestRequest();
                Assert.Zero(request.headers.size());
                Assert.Zero(request.@params.size());

                request.httpMethod = "get";
                request.requestURI = "http://example.com";
                request.resourcePath = "/Items";

                request.addHeader("Hello", "World");
                Assert.AreEqual(1, request.headers.size());

                request.addParameter("Hello", "World");
                Assert.AreEqual(1, request.@params.size());
            });
        }

        [Test]
        public void RestResponseIsImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var response = new RestResponse();
                Assert.Zero(response.headers.size());

                response.statusCode = 404;

                response.addHeader("Hello", "World");
                Assert.AreEqual(1, response.headers.size());
            });
        }

        [Test]
        public void RestContextIsImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                RestContext.request = new RestRequest();
                RestContext.response = new RestResponse();
            });
        }
    }
}

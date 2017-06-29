using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDemo.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using WebApiDemo.Models;
using System.Net;
using System.Net.Http.Headers;
namespace WebApiDemo.Controllers.Tests
{
    [TestClass()]
    public class GreetingControllerTests
    {
        [TestMethod()]
        public void PostGreetingTest()
        {
            var greetingName = "newgreeting";
            var greetingMessage = "Hello Test";
            var fakeRequest = new HttpRequestMessage(HttpMethod.Post, "http://localhost:9000/api/greeting");
            var greeting = new Greeting() { Name = greetingName, Message = greetingMessage };
            var service = new GreetingController();
            service.Request = fakeRequest;
            var response = service.PostGreeting(greeting);
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            Assert.AreEqual(new Uri("http://localhost:9000/api/greeting/newgreeting"), response.Headers.Location);
        }

        [TestMethod()]
        public async void Message_and_content_headers_are_not_in_same_coll()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:66530/html");
                var request = response.RequestMessage;
                var content_type = response.Content.Headers.ContentType;
            }
        }

        public void Tmp()
        {
            var request = new HttpRequestMessage();
            request.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,8/8;q=0.8");
            HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> accept = request.Headers.Accept;
        }
    }
}

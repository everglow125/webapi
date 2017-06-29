using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class GreetingController : ApiController
    {
        //
        // GET: /Greeting/

        public string GetGreeting()
        {
            return "hello world!";
        }

        public string GetGreeting(string id)
        {
            var greeting = _greetings.FirstOrDefault(x => x.Name == id);
            return greeting.Message;
        }

        public static List<Greeting> _greetings = new List<Greeting>();
        public HttpResponseMessage PostGreeting(Greeting greeting)
        {
            _greetings.Add(greeting);
            var greetingLocation = new Uri(this.Request.RequestUri, "greeting/" + greeting.Name);
            var response = this.Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = greetingLocation;
            return response;
        }



    }
}

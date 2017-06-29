﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace WebApiHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration(new Uri("http://localhost:6635"));
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }

                );
            var host = new HttpSelfHostServer(config);
            host.OpenAsync().Wait();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            host.CloseAsync().Wait();
        }
    }
}

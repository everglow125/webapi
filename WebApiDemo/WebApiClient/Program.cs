using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace WebApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var greetingServiceAddress = new Uri("http://localhost:6635/api/greeting");
            var client = new HttpClient();
            var result = client.GetAsync(greetingServiceAddress).Result;
            var greeting = result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(greeting);
            Console.ReadLine();
        }
    }
}

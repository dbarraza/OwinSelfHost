using System;
using Microsoft.Owin.Hosting;

namespace OwinSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "http://localhost:8080";

            using (WebApp.Start<StartUp>(uri))
            {

                Console.WriteLine("Started!!!");
                Console.ReadKey();
                Console.WriteLine("Stoped!!!");
            }
        }
    }
}

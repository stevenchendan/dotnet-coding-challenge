using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace dotnet_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            //read configuration from appsettings
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();


            Console.WriteLine("Hello World!");
        }
    }
}

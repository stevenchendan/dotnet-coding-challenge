using System;
using System.IO;
using dotnet_code_challenge.Helpers;
using Microsoft.Extensions.Configuration;

namespace dotnet_code_challenge
{
    class Program
    {
        private static readonly IRacingFileReader FileReader = new RacingFileReader();

        static void Main(string[] args)
        {

            //read configuration from appsettings
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();

            string feedDataLocation = root["FeedDataLocation"];
            FileReader.DisplayHorsesFromFile(feedDataLocation);
            Console.WriteLine("Finish!");
            Console.ReadLine();
        }
    }
}

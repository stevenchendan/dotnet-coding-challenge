using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using dotnet_code_challenge.FileParsing;

namespace dotnet_code_challenge.Helpers
{
    public class RacingFileReader : IRacingFileReader
    {
        public bool DisplayHorsesFromFile(string path)
        {
            //TODO: Use Factory pattern
            foreach (string file in Directory.GetFiles(path))
            {
                var fileExtension = Path.GetExtension(file).ToLower();
                FileParser fileParse = null;
                if (fileExtension == ".xml")
                {
                    fileParse = new XmlFileParser();
                }
                else if (fileExtension == ".json")
                {
                    fileParse = new JsonFileParser();
                }

                if (fileParse != null)
                {
                    var horses = fileParse.GetRacingHorses(file);
                    Console.WriteLine("Race Name is {0}", fileParse.RaceName);
                    fileParse.DisplayHorsesInOrder(horses);

                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}

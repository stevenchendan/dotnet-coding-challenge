using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using dotnet_code_challenge.Models;
using Newtonsoft.Json;

namespace dotnet_code_challenge.FileParsing
{
    class JsonFileParser : FileParser
    {
        public override List<RacingHorse> GetRacingHorses(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return new List<RacingHorse>();
            }
            try
            {
                using (StreamReader file = File.OpenText(path))
                {
                    var jsonSerializer = new JsonSerializer();
                    var deserializeResult = (WolferhamptonRace)jsonSerializer.Deserialize(file, typeof(WolferhamptonRace));

                    var horses = new List<RacingHorse>();
                    //Get all the participating horses.
                    RaceName = deserializeResult.RawData.FixtureName;
                    foreach (var participants in deserializeResult.RawData.Participants)
                    {
                        var horse = new RacingHorse
                        {
                            Number = participants.Id.ToString(),
                            Name = participants.Name
                        };

                        horses.Add(horse);
                    }
                    //Get price of the participating horse.
                    foreach (var horse in horses)
                    {
                        horse.Price = Convert.ToDecimal(deserializeResult.RawData.Markets[0].Selections.Find(s => s.Tags.name == horse.Name).Price);
                    }
                    return horses;
                }
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}

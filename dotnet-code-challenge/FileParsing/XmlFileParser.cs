using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.FileParsing
{
    class XmlFileParser : FileParser
    {
        public override List<RacingHorse> GetRacingHorses(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(CaulfieldRace));
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    var deserialize = (CaulfieldRace)xs.Deserialize(reader);
                    if (deserialize != null && deserialize.Track != null)
                    {
                        RaceName = deserialize.Track.Name;
                    }
                    else
                    {
                        RaceName = "";
                    }

                    var horses = new List<RacingHorse>();
                    if (deserialize != null)
                        foreach (var horse in deserialize.Races.Race.Horses.Horse)
                        {
                            var h = new RacingHorse
                            {
                                Number = horse.Number,
                                Name = horse.Name,
                            };
                            horses.Add(h);
                        }
                    var horsePriceList = deserialize.Races.Race.Prices.Price.Horses.Horse;
                    foreach (var horse in horses)
                    {
                        horse.Price = Convert.ToDecimal(horsePriceList.Find(p => p._Number == horse.Number).Price);
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

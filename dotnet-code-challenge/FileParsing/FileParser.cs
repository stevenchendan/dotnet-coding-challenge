using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleTables;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.FileParsing
{
    public abstract class FileParser
    {
        public string RaceName { get; set; }

        public abstract List<RacingHorse> GetRacingHorses(string path);

        public void DisplayHorsesInOrder(List<RacingHorse> horses)
        {

            if (horses == null || !horses.Any())
            {
                Console.WriteLine("Cannot find horses in the game");
            }
            else
            {
                var horsesOrderByPrice = horses.OrderBy(horse => horse.Price);
                var table = new ConsoleTable("Horse Name", "Horse Number", "Horse Price");
                foreach (var horse in horsesOrderByPrice)
                {
                    table.AddRow(horse.Name, horse.Number, horse.Price);
                }
                table.Write();
            }
        }
    }
}

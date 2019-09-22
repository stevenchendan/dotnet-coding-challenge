using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Models
{
    class Racing
    {
        public string Name { get; set; }

        public int RaceNumber { get; set; }

        public IEnumerable<RacingHorse> Horses { get; set; }
    }
}

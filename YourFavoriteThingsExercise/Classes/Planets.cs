using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThingsExercise.Classes
{
    enum starSizes
    {
        Dwarf=1,
        Giant,
        Supergiant,
        Hypergiant,
        Blackhole,
    }
    class Planets
    {
        public int NumOfMoons { get; set; }
        public string NameOfPlanet { get; set; }
        public starSizes OrbitingWhichSizeStar { get; set; }
        public Planets(int numMoons, string nameOfPlanet)
        {
            NumOfMoons = numMoons;
            NameOfPlanet = nameOfPlanet;
            Console.WriteLine($"You live on the planet {NameOfPlanet}, which has {NumOfMoons} moon(s).");
        }
    }
}

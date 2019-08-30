using System;
using System.Collections.Generic;
using YourFavoriteThingsExercise.Classes; 

namespace YourFavoriteThingsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ready to shred? Will you be shredding on an electric guitar or acoustic guitar (press '1' for electric, '2' for acoustic");

            var inputEGorAG = Console.ReadLine();

            Console.WriteLine("Ok! What brand is the guitar?");

            var inputBrand = Console.ReadLine();

            var myGuitar = new Guitars();

            if (inputEGorAG == "1")
            {
              myGuitar.Play(inputBrand, true);
            }
            if (inputEGorAG == "2")
            {
                myGuitar.Play(inputBrand, false);
            }

            var allMyGuitars = new List<string>();
            allMyGuitars.Add(inputBrand);

            Console.WriteLine($"Do you wanna sell your {inputBrand} guitar? (y/n)");
            var toSellOrNot = Console.ReadLine();

            if (toSellOrNot == "y")
            {
                myGuitar.Trade(inputBrand);
                allMyGuitars.Remove(inputBrand);
            }

            Console.WriteLine("What planet do you live on?");
            var inputPlanet = Console.ReadLine();
            Console.WriteLine("How many moons does it have?");
            var inputNumMoons = Console.ReadLine(); ;

            int makeMoonsInputNum = Int32.Parse(inputNumMoons);

            var myPlanet = new Planets(makeMoonsInputNum, inputPlanet);

            Console.WriteLine("What size star are you orbiting? Dwarf=1, Giant=2, Supergiant=3, Hypergiant=4, Blackhole=5");
            int inputStarSize = Int32.Parse(Console.ReadLine());
            if (inputStarSize==1)
            {
                myPlanet.OrbitingWhichSizeStar = starSizes.Dwarf;
                Console.WriteLine($"Your Planet is orbiting a {starSizes.Dwarf} star. That's Crazy!");
            }
            if (inputStarSize == 2)
            {
                myPlanet.OrbitingWhichSizeStar = starSizes.Giant;
                Console.WriteLine($"Your Planet is orbiting a {starSizes.Giant} star. That's Crazy!");
            }
            if (inputStarSize == 3)
            {
                myPlanet.OrbitingWhichSizeStar = starSizes.Supergiant;
                Console.WriteLine($"Your Planet is orbiting a {starSizes.Supergiant} star. That's Crazy!");
            }
            if (inputStarSize == 4)
            {
                myPlanet.OrbitingWhichSizeStar = starSizes.Hypergiant;
                Console.WriteLine($"Your Planet is orbiting a {starSizes.Hypergiant} star. I bet it's hot!");
            }
            if (inputStarSize == 5)
            {
                myPlanet.OrbitingWhichSizeStar = starSizes.Blackhole;
                Console.WriteLine($"Your Planet is orbiting a {starSizes.Blackhole} star. Good luck!");

            }
        }
    }
}

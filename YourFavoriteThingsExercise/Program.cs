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
            var input = Console.ReadLine();
            Console.WriteLine("Ok! What brand is the guitar?");
            var inputBrand = Console.ReadLine();

            var myGuitar = new Guitars();

            if (input == "1")
            {
              myGuitar.Play(inputBrand, true);
            }
            if (input == "2")
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
        }
    }
}

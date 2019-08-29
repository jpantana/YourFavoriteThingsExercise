using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThingsExercise.Classes
{
    class Guitars
    {
        public string Brand { get; set; }
        public bool IsElectric { get; set; }

        public void Play(string brand, bool elecOrAg)
        {
            if (elecOrAg == true)
            {
                Console.WriteLine($"You are playing a {brand} electric guitar");
            }
            else
            {
                Console.WriteLine($"You are playing a {brand} acoustic guitar");
            }

        }

        public void Trade(string brand)
        {
            Console.WriteLine($"You may regret selling your {brand}");
        }
    }
}

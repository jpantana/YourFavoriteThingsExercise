using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThingsExercise.Classes
{
    class Food
    {
        public int TasteScale { get; set; }
        public string Name { get; set; }
        public string GenreOfFood { get; set; }

        public Food(string genreOfFood, string nameOfFood, int tasteScale)
        {
            GenreOfFood = genreOfFood;
            Name = nameOfFood;
            TasteScale = tasteScale;
        }
    }
}

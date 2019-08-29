using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThingsExercise.Classes
{
    enum MovieGenre
    {
        Action=1,
        Horror,
        Comedy,
        Romance,
        Scifi,
        Documentary
    }
    class Movies
    {
        public string MovieName { get; set; }
        public MovieGenre Genre { get; set; }

        public Movies()
        {

        }
    }
}

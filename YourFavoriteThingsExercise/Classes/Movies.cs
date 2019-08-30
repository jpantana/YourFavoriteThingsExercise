using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThingsExercise.Classes
{
    class Movies
    {
        public string MovieName { get; set; }
        public string Genre { get; set; }

        public Movies(string movieName, string movieGenre)
        {
            MovieName = movieName;
            Genre = movieGenre;
        }
    }
}

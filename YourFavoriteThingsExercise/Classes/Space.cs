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
    class Space
    {
        public int NumOfMoons { get; set; }
        public starSizes OrbitingWhichSizeStar { get; set; }

        public Space()
        {

        }
    }
}

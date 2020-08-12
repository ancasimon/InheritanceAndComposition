using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Legs
{
    class CountryMusicSingerLegs : Legs
    {
        public CountryMusicSingerLegs(string clothing, bool isShaved) : base(clothing, "Boots", isShaved) //we hard-coded the shoes parameter!! and then removed it from the CountryMusicSingerLegs class!!
        {

        }

        public override void Dance()
        {
            Console.WriteLine("square dancing!");
        }
    }
}

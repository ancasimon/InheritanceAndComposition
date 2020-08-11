using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class PirateHead
    {
        public bool HasPatch { get; set; }
        public string FacialHair { get; set; }
        public HairColor HairColor { get; set; }
        public EyeColor EyeColor { get; set; }

        public void Sing()
        {
            Console.WriteLine($"The {HairColor} pirate sang 'Yo ho ho and a bottle of run' out of tune.");
        }

        public void Laugh()
        {
            Console.WriteLine($"Har Har Har.");
        }

        public void Greet()
        {
            Console.WriteLine("AAAAAAARGH!");
        }

    }

   

   
}

using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class CowgirlHead : Head
    {
        public bool HasHat { get; set; }
        public LipstickColor LipstickColor { get; set; }
        public void HairFlip()
        {
            Console.WriteLine($"The cowgirl flips her {HairColor} hair. She doesn't even care.");
        }
        public override void Greet()
        {
            Console.WriteLine("Howdy!");
        }

        public void Eat()
        {
            Console.WriteLine("The cowgirl eats her beans from a tin can.");
        }

    }

   
}

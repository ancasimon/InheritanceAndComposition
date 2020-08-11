using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class Head
    {
        //this is the class with the traits that every other head has in common! First thing to do: Create a class with all the things that all those heads have in common!!!
        //Then we go to the individual more specific classes and we specify that they are heads first: class AstronautHead : Head  --> which means AstronautHead class inherits from the class Head.
        public HairColor HairColor { get; set; }
        public EyeColor EyeColor { get; set; }

        public virtual void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
}

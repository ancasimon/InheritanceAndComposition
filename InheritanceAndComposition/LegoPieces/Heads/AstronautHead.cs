using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class AstronautHead : Head
    {
        public bool HasHelmet { get; set; } = true;
        //public HairColor HairColor { get; set; } If you see the warning about hidign a property > just delete this property because it is included in the Head base class.
        public bool HasFreckles { get; set; }

        //override allows you to change the behavior of the base class that you're inheriting from
        public override void Greet()
        {
            Console.WriteLine("Major Tom to Ground Control .... ");
            //talking to the class you're inheriting from. 
            base.Greet(); //this is calling the base class greeting. 
        }

        public void Observe()
        {
            Console.WriteLine("The Astronaut sees everything all at once. Across time.");
        }

    }
}

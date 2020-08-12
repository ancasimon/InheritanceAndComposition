using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Legs
{
    class CyclistLegs : Legs
    {
        public CyclistLegs() : base("Biker shorts", "Cyclist shoes", true) //this means: when someone makes a new CyclistLegs object, call the constructor from our base class!!!!!
        {  }

        public override void Dance()
        {
            Console.WriteLine("too busy cycling to dance");
        }
    }
}

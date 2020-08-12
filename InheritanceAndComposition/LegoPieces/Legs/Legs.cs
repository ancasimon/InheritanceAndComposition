using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Legs
{
    abstract class Legs //if I mark it as abstract, then this class cannot be instantiated => it is just an idea of a class that has to be inherited from
    {
        public string Clothing { get;  }

        public string Shoes { get;  }
        public bool IsShaved { get;  }

        //constructor - abstract classes cannot be constructed!! BUT - you can create a protected constructor > which means this constructor can be called only from a class that inherits from this class. 
        //BUT you have to call in in the subclass.!! This allows us to make the properties read-only!!!! but that means every subclass must call the base class constructor!!!! 
        protected Legs(string clothing, string shoes, bool isShaved)
        {
            Clothing = clothing;
            Shoes = shoes;
            IsShaved = isShaved;
        }

        public void Walk(int howManySteps)
        {
            Console.WriteLine($"The legs wearing {Clothing} walked {howManySteps} steps in {Shoes}.");
        }

        public void Kick()
        {
            Console.WriteLine("The legs kicked vigorously.");
        }

        public abstract void Dance();
    }
}

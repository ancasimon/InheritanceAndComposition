using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Torsos
{
    abstract class Torso
    {
        public ArmType ArmType { get; set; }
        public string Clothing { get; protected set; } //protected set --> allows this base class and any classes that inherit from it to set this property in the constructor - but this property cannot be set anywhere else!!!
        public string Accessory { get; set; }
        public Sex Sex { get; set; }

        //example of static field!!! - this static keyword is saying that every instance of the Torso class shares this field. Until now, the properties/methods/field were specific to each instance.
        static int _numberOfItemsPickedUp = 0;

        public virtual void Wave()
        {
            Console.WriteLine($"Waves Hello with their {ArmType} arm.");
        }

        //public void PickUp(string heavyObject)
        //{
        //    if (ArmType == ArmType.Strong)
        //    {
        //        Console.WriteLine($"I used my strong arms to pick up the {heavyObject}.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"My {ArmType} arms cannot pick up {heavyObject}.");
        //    }
        //}

        //protected bool IsStrong() 
        //{
        //    return ArmType == ArmType.Strong;
        //}

        //if I call a protected method inside another public method, then I can make the protected method virtual > which allows me to call it in any other classes that inherit this class:
        //regarding the method below: it is not virtual nor abstract, so this method's behavior is always the same!
        public void PickUp(string heavyObject)
        {
            if (IsStrong())
            {
                Console.WriteLine($"I used my strong arms to pick up the {heavyObject}.");
                _numberOfItemsPickedUp++;
            }
            else
            {
                Console.WriteLine($"My {ArmType} arms cannot pick up {heavyObject}.");
            }
        }
        //virtual protected member being overridden in *some* classes, not required. 
        //virtual can be overriddent but it defines a default behavior so it does not have to be overridden. 
        //use virtual when there is a reasonable default behavior but it might change / there might be some variance from class to class. 
        //protected virtual bool IsStrong()
        //{
        //    return ArmType == ArmType.Strong;
        //}

        //another option to the virtual method above is to create the method as an abstract method:
        //abstract method must be overridden in every class that inherits from this class!!!
        //use abstract when there is no reasonable default behavior. 
        protected abstract bool IsStrong();

    }

    enum ArmType
    {
        Skinny,
        Strong,
        Baby,
        Dinosaur
    }
    enum Sex
    {
        Unknown,
        Male,
        Female,
        Other
    }
}

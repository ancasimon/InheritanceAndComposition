using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Torsos
{
    class NinjaTorso : Torso
    {
        public string Weapon { get; set; }
        public NinjaTorso()
        {
            Clothing = "Black ninja-yoroi";
            Accessory = "Red cape";
            ArmType = ArmType.Strong;
            Sex = Sex.Unknown;
            Weapon = "Nunchuku";
        }

        public override void Wave()
        {
            //base.Wave();//the base keyword is the refrence to the class you are inheriting from; this allows you to call that method on the base class. This statement does exactly the same thing as the method in the base class. 
            Console.WriteLine($"The ninja torso waves its {ArmType} arms silently to get your attention.");
        }

        //we have overridden the IsStrong method to always return true:
        protected override bool IsStrong()
        {
            return true; 
        }
    }
}

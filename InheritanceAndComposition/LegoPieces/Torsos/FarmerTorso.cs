using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Torsos
{
    class FarmerTorso : Torso
    {
        public FarmerTorso(Sex sex)
        {
            Clothing = "Red plaid shirt";
            Accessory = "Garden hoe";
            ArmType = ArmType.Strong;
            Sex = sex;
        }

        public void Garden()
        {
            if (IsStrong())
            {
                Console.WriteLine("strong torso");
            }
            else
            {
                Console.WriteLine("not strong");
            }
        }

        protected override bool IsStrong()
        {
            //throw new NotImplementedException();
            return Sex == Sex.Female;
        }

    }
}

using InheritanceAndComposition.LegoPieces.Heads;
using InheritanceAndComposition.LegoPieces.Legs;
using InheritanceAndComposition.LegoPieces.Torsos;
using System;
using System.Collections.Generic;

namespace InheritanceAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            //var head = new AstronautHead(); //now, this variable is an AstronautHead;
            //Head astronautHead = new AstronautHead(); //we could also explicitly declare it as a Head! -- but this limits you to the traits of the Head object only!!! the compiler knows for sure it is a Head class - and can access only the lowest denominator traits. 
            //Head pirateHead = new PirateHead();
            //Head cowgirlHead = new CowgirlHead();
            //because the vaariables above are all defined as Head , we can call the common methods on them - but we cannot call the individual methods 

            //if we declare them as vars:
            var astronautHead = new AstronautHead(); //we could also explicitly declare it as a Head! -- but this limits you to the traits of the Head object only!!! the compiler knows for sure it is a Head class - and can access only the lowest denominator traits. 
            var pirateHead = new PirateHead();
            var cowgirlHead = new CowgirlHead();


            cowgirlHead.Greet();
            cowgirlHead.HairFlip();

            pirateHead.Greet();
            pirateHead.Sing();

            astronautHead.Greet();
            astronautHead.Observe();

            var heads = new List<Head>();
            heads.Add(astronautHead);
            heads.Add(pirateHead);
            heads.Add(cowgirlHead);

            Console.WriteLine(new string( '=', 50));
            foreach (var head in heads)
            {
                Console.WriteLine($"The {head.HairColor}-haired, {head.EyeColor}-eyed head is greeting you ...");
                head.Greet();
            }
            //we can access what they share in common - but none of the things they don't share in common!!!


            //var torso = new Torso(); //NOTE: you can no longer create this instance once you mark the Torso class as abstract!

            var farmerTorso = new FarmerTorso(Sex.Male);
            var ninjaTorso = new NinjaTorso();

            farmerTorso.PickUp("Goat");
            ninjaTorso.PickUp("Box");

            var cyclistLegs = new CyclistLegs();
            var countryMusicSingerLegs = new CountryMusicSingerLegs("Blue Jeans", false);

            var astronaut = new MiniFigure("Major Tom", astronautHead, ninjaTorso, countryMusicSingerLegs);
            var cowgirl = new MiniFigure("Jessie", cowgirlHead, farmerTorso, cyclistLegs);

            astronaut.SayHello();
            cowgirl.SayHello();
        }
    }
}

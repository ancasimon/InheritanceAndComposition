using InheritanceAndComposition.LegoPieces.Heads;
using InheritanceAndComposition.LegoPieces.Legs;
using InheritanceAndComposition.LegoPieces.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition
{
    class MiniFigure
    {
        public string Name { get; }
        public Head Head { get;}
        public Torso Torso { get; }
        public Legs Legs { get; }

        public MiniFigure(string name, Head head, Torso torso, Legs legs)
        {
            Name = name;
            Head = head;
            Torso = torso;
            Legs = legs;
        }

        public void SayHello()
        {
            Console.WriteLine($"{Name} is saying hello:");
            Head.Greet();
            Torso.Wave();
            Legs.Walk(20);

        }
    }
}

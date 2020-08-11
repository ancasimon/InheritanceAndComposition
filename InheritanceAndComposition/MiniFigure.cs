using InheritanceAndComposition.LegoPieces.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition
{
    class MiniFigure
    {
        public string Name { get; private set; }
        public Head Head { get; private set; }

        public MiniFigure(string name, Head head)
        {
            Name = name;
            Head = head;
        }

        public void SayHello()
        {
            Console.WriteLine($"{Name} is saying hello:");
            Head.Greet();
        }
    }
}

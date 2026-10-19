using System;
using System.Collections.Generic;
using System.Text;

namespace _25_ConstrainedInterfaces
{
    internal class Skeleton : ICreature
    {
        public void Spawn() => Console.WriteLine("Скелет заспавнился!");
        public Skeleton() { }
    }
}

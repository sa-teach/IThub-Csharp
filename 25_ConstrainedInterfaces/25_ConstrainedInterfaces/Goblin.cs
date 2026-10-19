using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _25_ConstrainedInterfaces
{
    internal class Goblin : ICreature
    {
        public void Spawn() => Console.WriteLine("Гоблин заспавнился!");
        public Goblin() { }
    }
}

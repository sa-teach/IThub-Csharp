using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _25_ConstrainedInterfaces
{
    internal class Skeleton : ICreature
    {
        public void Spawn() => Console.WriteLine("Скелет заспавнился!");
        public void Attack() => Console.WriteLine("Скелет атакует игрока!");
        public Skeleton() { }
    }
}

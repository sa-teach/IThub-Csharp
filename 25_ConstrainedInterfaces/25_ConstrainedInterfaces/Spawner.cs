using System;
using System.Collections.Generic;
using System.Text;

namespace _25_ConstrainedInterfaces
{
    internal class Spawner<T> where T : ICreature, new()
    {
        public void SpawnMany(int count)
        {
            for (int i = 0; i < count; i++)
            {
                T creature = new T();
                Console.Write($"{i+1}-й ");
                creature.Spawn();
                creature.Attack();
            }
        }
    }
}

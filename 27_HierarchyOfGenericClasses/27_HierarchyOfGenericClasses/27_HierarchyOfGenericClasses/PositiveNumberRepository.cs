using System;
using System.Collections.Generic;
using System.Text;

namespace _27_HierarchyOfGenericClasses
{
    internal class PositiveNumberRepository : Repository<int>
    {
        public bool Add(int item)
        {
            if (item > 0) return base.Add(item);
            else
            {
                Console.WriteLine("Число должно быть положительным!");
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _27_HierarchyOfGenericClasses
{
    internal class LoggingRepository<T> : Repository<T>
    {
        public bool Add(T item)
        {
            Console.WriteLine($"[LOG] Добавлен элемент {item}.");
            return base.Add(item);
        }
    }
}

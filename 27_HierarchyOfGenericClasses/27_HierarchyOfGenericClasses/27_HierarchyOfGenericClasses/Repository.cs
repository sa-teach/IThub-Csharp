using System;
using System.Collections.Generic;
using System.Text;

namespace _27_HierarchyOfGenericClasses
{
    internal class Repository<T>
    {
        protected List<T> items = new();
        public virtual bool Add(T item) { items.Add(item); return true; }
        public void PrintItems()
        {
            Console.WriteLine("Вывод содержимого репозитория:");
            foreach (T item in items) Console.Write(item + " ");
            Console.WriteLine();
        } 
    }
}

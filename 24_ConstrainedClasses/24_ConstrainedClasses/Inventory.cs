using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _24_ConstrainedClasses
{
    internal class Inventory<T> where T : Item
    {
        public List<T> items = new List<T>();
        public void Add(T item) => items.Add(item);
        public int Count() => items.Count();
        public decimal GetTotalValue()
        {
            decimal total = 0;
            foreach (T item in items) total+= item.Value;
            return total;
        }
        public void PrintAll()
        {
            foreach (T item in items) Console.WriteLine(item.GetDescription());
        }
    }
}

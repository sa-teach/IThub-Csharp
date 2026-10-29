using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace _29_Constrained_Interfaces
{
    internal class InMemoryRepository<T> : IRepository<T> where T : IEntity
    {
        public List<T> items = new List<T>();
        public void Add(T item)
        {
            foreach (T i in items)
            {
                if (i.Id == item.Id)
                {
                    Console.WriteLine("ID должен быть уникален! Элемент не добавлен.");
                    return;
                }
            }
            items.Add(item);
        }
        public T? GetById(int id)
        {
            foreach (T item in items)
            {
                if (item.Id == id) return item;
            }
            Console.WriteLine("Элемента с таким id нет в списке!");
            return default;
        }
        public void PrintItems()
        {
            Console.WriteLine("Вывод содержимого списка:");
            if (items.Count == 0)
            {
                Console.WriteLine("Список пуст!");
                return;
            }
            foreach (T item in items) Console.WriteLine(item);
        }
    }
}

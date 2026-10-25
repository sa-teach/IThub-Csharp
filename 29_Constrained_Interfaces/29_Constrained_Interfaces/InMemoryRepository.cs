using System;
using System.Collections.Generic;
using System.Text;

namespace _29_Constrained_Interfaces
{
    internal class InMemoryRepository<T> : IRepository<T> where T : IEntity
    {
        List<T> items = new List<T>();
        public void Add(T item) => items.Add(item);
        public T? GetById(int id) => items[id];
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _29_Constrained_Interfaces
{
    internal interface IRepository<T> where T : IEntity
    {
        void Add(T item);
        T? GetById(int id);
    }
}

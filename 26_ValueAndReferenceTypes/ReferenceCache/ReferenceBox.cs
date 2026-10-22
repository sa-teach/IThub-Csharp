using _1_ReferenceBox;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _1_ReferenceBox

{
    internal class ReferenceBox<T> where T : class
    {
        private T? item;
        public T? Get() => item;
        public void Set(T newItem) => item = newItem;
        public bool IsEmpty() => item is null;
    }
}
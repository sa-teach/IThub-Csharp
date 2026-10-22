using System;
using System.Collections.Generic;
using System.Text;

namespace _1_ReferenceBox
{
    internal class ValueBox<T> where T : struct
    {
        private T? item;
        public T? Get() => item;
        public void Set(T newItem) => item = newItem;
        public bool IsEmpty() => item is null;
    }
}

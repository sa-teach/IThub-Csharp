using System;
using System.Collections.Generic;
using System.Text;

namespace _26_ValueAndReferenceTypes
{
    internal class ValueCache<T> where T : struct
    {
        private T? value;
        public void Set(T item) => value = item;
        public T? Get() => value;
        public bool TryGet(out T? v) => (v = value) is not null;
    }
}

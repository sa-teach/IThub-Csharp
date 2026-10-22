using System;
using System.Collections.Generic;
using System.Text;

namespace _26_ValueAndReferenceTypes
{
    internal class ReferenceCache<T> where T : class
    {
        private T? value;
        public void Set(T item) => value = item;
        public bool TryGet(out T? v) => (v = value) is not null;
    }

}

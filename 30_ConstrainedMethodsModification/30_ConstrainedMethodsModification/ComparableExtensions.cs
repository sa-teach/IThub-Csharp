using System;
using System.Collections.Generic;
using System.Text;

namespace _30_ConstrainedMethodsModification
{
    internal static class ComparableExtensions
    {
        public static T? FindMax<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            T? max = default;
            bool first = true;
            foreach (T item in source)
            {
                if (first || item.CompareTo(max) > 0)
                {
                    max = item;
                    first = false;
                }
            }
            return max;
        }
    }
}

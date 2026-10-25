using System;
using System.Collections.Generic;
using System.Text;

namespace _30_ConstrainedMethodsModification
{
    internal static class PrintableExtensions
    {
        public static void PrintAll<T>(this IEnumerable<T> source, string prefix)
        {
            foreach (T item in source) Console.WriteLine($"[{prefix}] {item}");
        }
    }
}

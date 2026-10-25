using System;
using System.Collections.Generic;
using System.Text;

namespace _30_ConstrainedMethodsModification
{
    internal static class FillableExtensions
    {        

        public static void FillList<T>(this List<T> list, Func<T> create)
        {
            Console.Write("Введите длину списка: ");
            int len = Logic.SafeInputIntPos();

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Ввод {i + 1}-го элемента");
                list.Add(create());
            }
        }
    }
}

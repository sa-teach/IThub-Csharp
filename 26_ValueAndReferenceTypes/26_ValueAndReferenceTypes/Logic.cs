using System;
using System.Collections.Generic;
using System.Text;

namespace _26_ValueAndReferenceTypes
{
    internal class Logic
    {
        public static double SafeInputDouble()
        {
            double a = 0;
            bool done = false;
            while (!done)
            {
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                    done = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат данных!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Введено слишком большое число!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка! " + e.Message);
                }
            }
            return a;
        }

    }
}

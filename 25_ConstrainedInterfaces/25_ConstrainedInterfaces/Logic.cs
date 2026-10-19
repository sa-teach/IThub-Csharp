using System;
using System.Collections.Generic;
using System.Text;

namespace _25_ConstrainedInterfaces
{
    internal class Logic
    {
        public static int SafeInputInt()
        {
            int a = 0;
            while (a <= 0)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a <= 0) Console.WriteLine("Число должно быть положительным!");
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

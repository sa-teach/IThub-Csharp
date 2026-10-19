using System;
using System.Collections.Generic;
using System.Text;

namespace _23_ConstrainedTypes
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

        public static string SafeInputString()
        {
            string a = "";
            while (a == "")
            {
                a = Console.ReadLine();
                if (a == "") Console.WriteLine("Пустая строка не принимается!");
            }
            return a;
        }

        public static Player InputPlayer()
        {
            Console.Write("Введите имя игрока: ");
            string name = Logic.SafeInputString();

            Console.Write("Введите очки игрока: ");
            int points = Logic.SafeInputInt();
            Console.WriteLine();

            return new Player(name, points);
        }

        public static List<T> FillList<T>(Func<T> create)
        {
            Console.Write("Введите длину списка: ");
            int len = Logic.SafeInputInt();

            List<T> list = new List<T>();
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Ввод {i+1}-го элемента:");
                T item = create();
                list.Add(item);
            }
            return list;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _30_ConstrainedMethodsModification
{
    internal class Logic
    {
        public static int SafeInputInt()
        {
            int a = 0;
            bool done = false;
            while (!done)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
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

        public static int SafeInputIntPos()
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
        public static Player PlayerCreate()
        {
            Console.Write("Введите имя игрока: ");
            string name = Logic.SafeInputString();
            Console.Write("Введите очки игрока: ");
            int score = Convert.ToInt32(Logic.SafeInputIntPos());
            return new Player(name, score);
        }
    }
}

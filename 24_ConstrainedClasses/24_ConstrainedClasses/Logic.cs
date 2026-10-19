using System;
using System.Collections.Generic;
using System.Text;

namespace _24_ConstrainedClasses
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

        public static Weapon WeaponCreate()
        {
            Console.Write("Введите название оружия: ");
            string name = SafeInputString();
            Console.Write("Введите стоимость оружия: ");
            decimal value = (decimal)SafeInputInt();
            return new Weapon(name, value);
        }
        public static Potion PotionCreate()
        {
            Console.Write("Введите название зелья: ");
            string name = SafeInputString();
            Console.Write("Введите стоимость зелья: ");
            decimal value = (decimal)SafeInputInt();
            return new Potion(name, value);
        }

        public static void FillList<T>(Inventory<T> inventory, Func<T> create) where T : Item
        {
            Console.Write("Введите длину списка: ");
            int len = Logic.SafeInputInt();

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Ввод {i + 1}-го элемента");
                inventory.Add(create());
            }
        }
    }
}

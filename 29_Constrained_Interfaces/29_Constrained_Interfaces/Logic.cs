using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _29_Constrained_Interfaces
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

        public static Product CreateProduct()
        {
            Console.Write("Введите id продукта: ");
            int id = SafeInputInt();

            Console.Write("Введите название продукта: ");
            string name = SafeInputString();

            Console.Write("Введите цену продукта: ");
            double price = SafeInputDouble();

            return new Product(id, name, price);
        }

        public static Customer CreateCustomer()
        {
            Console.Write("Введите id пользователя: ");
            int id = SafeInputInt();

            Console.Write("Введите имя пользователя: ");
            string name = SafeInputString();

            Console.Write("Введите баланс пользователя: ");
            double balance = SafeInputDouble();

            return new Customer(id, name, balance);
        }

        public static void FillList<T>(InMemoryRepository<T> rep, Func<T> create) where T : IEntity
        {
            Console.Write("Введите длину списка: ");
            int len = SafeInputInt();

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Ввод {i + 1}-го элемента:");
                T item = create();
                rep.Add(item);
                Console.WriteLine();
            }
        }
    }
}

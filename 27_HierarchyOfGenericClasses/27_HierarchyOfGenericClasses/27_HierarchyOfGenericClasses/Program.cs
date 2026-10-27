using System.Diagnostics.Metrics;

namespace _27_HierarchyOfGenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PositiveNumberRepository positiveNumbersRepository = new PositiveNumberRepository();
            LoggingRepository<string> loggingStringRepository = new LoggingRepository<string>();
            LoggingRepository<int> loggingIntRepository = new LoggingRepository<int>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ──────────────────────────────┐");
                Console.WriteLine("|  1 - Добавить число в PositiveNumberRepository    |");
                Console.WriteLine("|  2 - Добавить строку в LoggingStringRepository    |");
                Console.WriteLine("|  3 - Добавить число в LoggingIntRepository        |");
                Console.WriteLine("|  4 - Вывести содержимое LoggingStringRepository   |");
                Console.WriteLine("|  5 - Вывести содержимое PositiveNumberRepository  |");
                Console.WriteLine("|  6 - Вывести содержимое LoggingIntRepository      |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ         |");
                Console.WriteLine("└───────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введите целое положительное число: ");
                        Console.WriteLine(positiveNumbersRepository.Add(Convert.ToInt32(Console.ReadLine())));
                        break;

                    case "2":
                        Console.Write("Введите что угодно: ");
                        Console.WriteLine(loggingStringRepository.Add(Console.ReadLine()));
                        break;

                    case "3":
                        Console.Write("Введите целое число: ");
                        Console.WriteLine(loggingIntRepository.Add(Convert.ToInt32(Console.ReadLine())));
                        break;

                    case "4":
                        loggingStringRepository.PrintItems();
                        break;

                    case "5":
                        positiveNumbersRepository.PrintItems();
                        break;

                    case "6":
                        loggingIntRepository.PrintItems();
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

//| Действие | Ожидаемый результат |
//| PositiveNumberRepository.Add(5) | true, число добавлено |
//| PositiveNumberRepository.Add(-3) | false, число не добавлено |
//| LoggingRepository<int>.Add(10) | лог выведен, затем число добавлено |
//| LoggingRepository<string>.Add("текст") | лог выведен, затем строка добавлена |

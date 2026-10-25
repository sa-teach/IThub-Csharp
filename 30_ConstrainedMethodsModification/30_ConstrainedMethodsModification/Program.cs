using System.Net.NetworkInformation;

namespace _30_ConstrainedMethodsModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<Player> players = new List<Player>();           

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ───────────────────────────┐");
                Console.WriteLine("|  1 - Заполнить список int                      |");
                Console.WriteLine("|  2 - Заполнить список Player                   |");
                Console.WriteLine("|  3 - Найти наибольший элемент в списке int     |");
                Console.WriteLine("|  4 - Найти наибольший элемент в списке Player  |");
                Console.WriteLine("|  5 - Вывести элементы списка int               |");
                Console.WriteLine("|  6 - Вывести элементы списка Player            |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ      |");
                Console.WriteLine("└────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        numbers.FillList<int>(Logic.SafeInputInt);
                        break;

                    case "2":
                        players.FillList<Player>(Logic.PlayerCreate);
                        break;

                    case "3":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Список пуст!");
                            break;
                        }
                        Console.WriteLine("Самое большое число");
                        Console.WriteLine(numbers.FindMax());
                        break;

                    case "4":
                        if (players.Count == 0)
                        {
                            Console.WriteLine("Список пуст!");
                            break;
                        }
                        Console.WriteLine("Лучший результат");
                        Console.WriteLine(players.FindMax());
                        break;

                    case "5":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Список пуст!");
                            break;
                        }
                        Console.Write("Введите префикс для вывода: ");
                        numbers.PrintAll(Console.ReadLine());
                        break;

                    case "6":
                        if (players.Count == 0)
                        {
                            Console.WriteLine("Список пуст!");
                            break;
                        }
                        Console.Write("Введите префикс для вывода: ");
                        players.PrintAll(Console.ReadLine());
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }

            }

        }
    }
}

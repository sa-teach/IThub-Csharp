namespace _23_ConstrainedTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ──────────────────────┐");
                Console.WriteLine("|  1 - Сравнить очки в списке int           |");
                Console.WriteLine("|  2 - Сравнить очки в списке double        |");
                Console.WriteLine("|  3 - Сравнить очки в списке Player        |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ |");
                Console.WriteLine("└───────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Заполняем список int");
                        List<int> listInt = Logic.FillList(Logic.SafeInputInt);
                        Console.WriteLine("Лучший результат: " + Player.FindBest(listInt)); 
                        break;

                    case "2":
                        Console.WriteLine("Заполняем список double");
                        List<double> listDouble = Logic.FillList(Logic.SafeInputDouble);
                        Console.WriteLine("Лучший результат: " + Player.FindBest(listDouble));
                        break;

                    case "3":
                        Console.WriteLine("Заполняем список Player");
                        List<Player> listPlayer = Logic.FillList(Logic.InputPlayer);
                        Console.WriteLine("Игрок с лучшим результатом: " + Player.FindBest(listPlayer));
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}

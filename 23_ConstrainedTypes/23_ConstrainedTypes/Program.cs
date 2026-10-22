namespace _23_ConstrainedTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //| Вход | Ожидаемый результат |
            //| FindBest(new List<double> { 3.5, 7.2, 1.1 }) | 7.2 |
            //| FindBest на трёх Player с очками 10, 25, 18 | игрок с очками 25 |
            //| без where T : IComparable<T> | ошибка компиляции CS1061 |


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
                        Console.WriteLine("Лучший результат: " + Logic.FindBest(listInt)); 
                        break;

                    case "2":
                        Console.WriteLine("Заполняем список double");
                        List<double> listDouble = Logic.FillList(Logic.SafeInputDouble);
                        Console.WriteLine("Лучший результат: " + Logic.FindBest(listDouble));
                        break;

                    case "3":
                        Console.WriteLine("Заполняем список Player");
                        List<Player> listPlayer = Logic.FillList(Logic.InputPlayer);
                        Console.WriteLine("Игрок с лучшим результатом: " + Logic.FindBest(listPlayer));
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}

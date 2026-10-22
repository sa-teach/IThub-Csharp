namespace _1_ReferenceBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReferenceBox<string> r = new ReferenceBox<string>();
            ValueBox<int> v = new ValueBox<int>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ──────────────────────────────────────────────┐");
                Console.WriteLine("|  1 - задать значение item переменной ReferenceBox<string>         |");
                Console.WriteLine("|  2 - задать значение item переменной ValueBox<int>                |");
                Console.WriteLine("|  3 - проверить значение переменной ReferenceBox<string>           |");
                Console.WriteLine("|  4 - проверить значение переменной ValueBox<int>                  |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ                         |");
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введите новое значение value: ");
                        r.Set(Console.ReadLine());
                        break;

                    case "2":
                        Console.Write("Введите новое значение value: ");
                        v.Set(Logic.SafeInputInt());
                        break;

                    case "3":
                        Console.WriteLine($"Проверка на item is null: {r.IsEmpty()}");
                        if (!r.IsEmpty()) Console.WriteLine($"Значение value: {r.Get()}");
                        break;

                    case "4":
                        Console.WriteLine($"Проверка на item is null: {v.IsEmpty()}");
                        if (!v.IsEmpty()) Console.WriteLine($"Значение value: {v.Get()}");
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

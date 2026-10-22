namespace _26_ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReferenceCache<string> r = new ReferenceCache<string>();
            ValueCache<double> v = new ValueCache<double>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ──────────────────────────────────────────────┐");
                Console.WriteLine("|  1 - посмотреть значение value переменной ReferenceCache<string>  |");
                Console.WriteLine("|  2 - посмотреть значение value переменной ValueCache<double>      |");
                Console.WriteLine("|  3 - задать значение value переменной ReferenceCache<string>      |");
                Console.WriteLine("|  4 - задать значение value переменной ValueCache<double>          |");
                Console.WriteLine("|  5 - проверить TryGet переменной ReferenceCache<string>           |");
                Console.WriteLine("|  6 - проверить TryGet переменной ValueCache<double>               |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ                         |");
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Значение value: " + r.Get());                        
                        break;

                    case "2":
                        Console.WriteLine("Значение value: " + v.Get());
                        break;

                    case "3":
                        Console.Write("Введите новое значение value: ");
                        r.Set(Console.ReadLine());
                        break;

                    case "4":
                        Console.Write("Введите новое значение value: ");
                        v.Set(Logic.SafeInputDouble());
                        break;

                    case "5":
                        Console.WriteLine($"Проверка на value is not null: {r.TryGet(out string? r1)}; {r1} ");
                        break;

                    case "6":
                        Console.WriteLine($"Проверка на value is not null: {v.TryGet(out double? v1)}; {v1}");
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

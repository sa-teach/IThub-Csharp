namespace _26_ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReferenceCache<string> r = new ReferenceCache<string>();
            ValueCache<double> v = new ValueCache<double>();

            new ReferenceCache<int>();
            new ValueCache<string>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ──────────────────────────────────────────────┐");
                Console.WriteLine("|  1 - задать значение value переменной ReferenceCache<string>      |");
                Console.WriteLine("|  2 - задать значение value переменной ValueCache<double>          |");
                Console.WriteLine("|  3 - проверить TryGet переменной ReferenceCache<string>           |");
                Console.WriteLine("|  4 - проверить TryGet переменной ValueCache<double>               |");
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
                        v.Set(Logic.SafeInputDouble());
                        break;

                    case "3":
                        Console.WriteLine($"Проверка на value is not null: {r.TryGet(out string? r1)}");
                        if (r1 is not null) Console.WriteLine($"Значение value: {r1}");
                        break;

                    case "4":
                        Console.WriteLine($"Проверка на value is not null: {v.TryGet(out double? v1)}");
                        if (v1 is not null) Console.WriteLine($"Значение value: {v1}");
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

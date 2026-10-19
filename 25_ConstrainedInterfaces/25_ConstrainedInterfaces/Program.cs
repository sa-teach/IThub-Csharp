namespace _25_ConstrainedInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spawner<Skeleton> spawnerSkeleton = new Spawner<Skeleton>();
            Spawner<Goblin> spawnerGoblin = new Spawner<Goblin>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ───────────────────────┐");
                Console.WriteLine("|  1 - заспавнить скелетов                   |");
                Console.WriteLine("|  2 - заспавнить гоблинов                   |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ  |");
                Console.WriteLine("└────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Сколько скелетов заспавним? ");
                        spawnerSkeleton.SpawnMany(Logic.SafeInputInt());
                        break;

                    case "2":
                        Console.Write("Сколько гоблинов заспавним? ");
                        spawnerGoblin.SpawnMany(Logic.SafeInputInt());
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

using System.Numerics;

namespace _20_EventHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hasSubscription = false;
            EventHandler<HealthChangedEventArgs> handler = (sender, e) =>
                Console.WriteLine($"HP изменилось: {e.OldHealth} -> {e.NewHealth}");

            Character ch = new Character();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ─────────────────────────┐");
                Console.WriteLine("|  1 - добавить подписку на HealthChanged      |");
                Console.WriteLine("|  2 - отменить подписку на HealthChanged      |");
                Console.WriteLine("|  3 - нанести урон персонажу                  |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ    |");
                Console.WriteLine("└──────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        if (hasSubscription)
                        {
                            Console.WriteLine("Подписка на HealthChanged уже есть!");
                            break;
                        }
                        ch.HealthChanged += handler;
                        hasSubscription = true;
                        break;

                    case "2":
                        if (!hasSubscription)
                        {
                            Console.WriteLine("Подписки на HealthChanged уже нет!");
                            break;
                        }
                        ch.HealthChanged -= handler;
                        hasSubscription = false;
                        break;

                    case "3":
                        ch.TakeDamage();
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

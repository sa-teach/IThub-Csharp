using System.Diagnostics.Metrics;
using System.Reflection;

namespace _22_EventsComplex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountdownTimer counter = new CountdownTimer();

            EventHandler<int> logger = (s, n) => Console.WriteLine($"Тик №{n}");         
            EventHandler<int> halfStopper = null!;

            halfStopper = (s, i) =>
            {
                if (s is CountdownTimer timer && i <= timer.InitialTime / 2)
                {
                    Console.WriteLine("Прошло больше половины отсчёта. Временный счётчик отписывает себя.");
                    counter.Tick -= halfStopper;
                    return;
                }
                Console.WriteLine("Сообщение от временного обработчика");
            };

            EventHandler? finalMessage = (s, n) => Console.WriteLine("Отсчёт окончен!");

            counter.Tick += logger;
            counter.Tick += halfStopper;
            counter.Finished += finalMessage;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ───────────────────────────────────────────────────────────────────────────────────┐");
                Console.WriteLine("|  1 - Запустить обратный отсчёт                                                                         |");
                Console.WriteLine("|  2 - Отменить подписку на событие logger (вывод оставшегося времени)                                   |");
                Console.WriteLine("|  3 - Отменить подписку на событие halfStopper (временный обработчик, отключающийся в середине отсчёта) |");
                Console.WriteLine("|  4 - Отменить подписку на событие finalMessage (сообщение, выводящееся после отсчёта)                  |");
                Console.WriteLine("|  5 - Подписаться на все события                                                                        |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ                                                              |");
                Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введите количество секунд для отсчёта: ");
                        int count = Logic.SafeInputInt();
                        counter.Start(count);
                        break;

                    case "2":                        
                        counter.Tick -= logger;
                        break;

                    case "3":
                        counter.Tick -= halfStopper;
                        break;

                    case "4":
                        counter.Finished -= finalMessage;
                        break;

                    case "5":
                        counter.Tick -= logger;
                        counter.Tick -= halfStopper;
                        counter.Finished -= finalMessage;

                        counter.Tick += logger;
                        counter.Tick += halfStopper;
                        counter.Finished += finalMessage;
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

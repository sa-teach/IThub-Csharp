using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace _21_Variability
{
    internal class Program
    {
        // 1
        public delegate TCharacter CharacterProducer<out TCharacter>();
        public static Wizard GetWizard() => new Wizard();

        // 2
        delegate void CharacterConsumer<in TCharacter>(TCharacter character);
        public static void HandleCharacter(Character c) => Console.WriteLine($"Обработан персонаж: {c.GetType().Name}");


        static void Main(string[] args)
        {

            // 3
            Func<Character> getWizard = () => new Wizard();
            Func<Character> getCharacter = getWizard;

            // 4
            Action<Character> handleCharacter = c => Console.WriteLine($"Обработан персонаж: {c.GetType().Name}");
            Action<Wizard> handleWizard = handleCharacter;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ───────────────────────────────────────────────────────────────────────────────────────────────┐");
                Console.WriteLine("|  1 - Создать волшебника через ковариантный делегат (TCharacter CharacterProducer<out TCharacter>())                |");
                Console.WriteLine("|  2 - Обработать персонажей через контравариантный делегат (CharacterConsumer<in TCharacter>(TCharacter character)) |");
                Console.WriteLine("|  3 - Создать волшебника через Func<Character>                                                                      |");
                Console.WriteLine("|  4 - Обработать персонажей через Action<Wizard>                                                                    |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ                                                                          |");
                Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        CharacterProducer<Character> p = GetWizard;
                        Character Wizard = p();
                        Console.WriteLine();
                        break;

                    case "2":
                        CharacterConsumer<Wizard> consumer = HandleCharacter;
                        HandleCharacter(new Character());

                        // consumer(new Character()); // тут ошибка компиляции

                        Console.WriteLine();
                        consumer(new Wizard());
                        Console.WriteLine();
                        break;

                    case "3":
                        Character c = getCharacter();
                        Console.WriteLine();
                        break;

                    case "4":
                        handleCharacter(getWizard());
                        Console.WriteLine();
                        handleCharacter(getCharacter());
                        Console.WriteLine();
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

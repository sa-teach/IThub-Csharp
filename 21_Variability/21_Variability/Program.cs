using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using static _21_Variability.Program;

namespace _21_Variability
{
    internal class Program
    {
        // 1
        public delegate TCharacter CharacterProducer<out TCharacter>();
        public static Wizard spawnWizard() => new Wizard();

        // 2
        delegate void CharacterConsumer<in TCharacter>(TCharacter character);
        public static void DamageCharacter(Character c) => Console.WriteLine($"Нанесён урон персонажу {c.Name}");

        static void Main(string[] args)
        {
            // 3
            Func<Character> spawnWizardFunc = () => new Wizard();
            Func<Character> getCharacterFunc = spawnWizardFunc;

            // 4
            Action<Character> damageCharacterAction = c => Console.WriteLine($"Нанесён урон персонажу {c.Name}");
            Action<Character> handleWizardAction = damageCharacterAction;

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
                        Console.WriteLine("Создаём волшебника через CharacterProducer <Character> = spawnWizard");
                        CharacterProducer<Character> p = spawnWizard;
                        Character c1 = p();                        
                        Console.WriteLine($"Тип созданного персонажа: {c1.Name}");
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine("Обрабатываем волшебника через CharacterConsumer<Wizard> = DamageCharacter(Character c)");
                        CharacterConsumer<Wizard> consumer = DamageCharacter;

                        // consumer(new Character()); // тут ошибка компиляции

                        consumer(spawnWizard());                   
                        Console.WriteLine();
                        break;

                    case "3":                        
                        Console.WriteLine("Создаём волшебника через Func<Character> getCharacter = spawnWizard");
                        Character c2 = getCharacterFunc();
                        Console.WriteLine($"Тип созданного персонажа: {c2.Name}");
                        Console.WriteLine();
                        break;

                    case "4":                        
                        Console.WriteLine("Обрабатываем волшебника через Action<Wizard> handleWizard = damageCharacter");
                        damageCharacterAction(getCharacterFunc());
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

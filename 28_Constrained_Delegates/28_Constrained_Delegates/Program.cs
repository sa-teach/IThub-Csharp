using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static _28_Constrained_Delegates.Program;

namespace _28_Constrained_Delegates
{
    internal class Program
    {
        public struct Stat<T> {
            public T Value;
            public string Name;
            public override string ToString() => $"{Name}: {Value}";
        }
        public delegate TResult StatTransformer<T, TResult>(T value);

        public static Stat<TResult> Apply<T, TResult>(Stat<T> source, StatTransformer<T, TResult> transformer)
        {
            return new Stat<TResult>
            {
                Value = transformer(source.Value),
                Name = source.Name
            };
        }

        static void Main(string[] args)
        {
            Stat<int> health = new Stat<int> { Value = 50, Name = "Здоровье" };

            Stat<int> healthBonus = Apply(health, level => level + 10);
            Stat<string> healthStatus = Apply(health, level => level >= 50 ? "в норме" : "на низком уровне!");

            Console.WriteLine("Значение Value в обычном Stat:");
            Console.WriteLine(health);
            Console.WriteLine();

            Console.WriteLine("Значение Value после прибавления бонуса:");
            Console.WriteLine(healthBonus);
            Console.WriteLine();            

            Console.WriteLine("Value после перевода в string:");
            Console.WriteLine(healthStatus);
            Console.WriteLine();

            Stat<int> newHealth = new Stat<int> { Value = 30, Name = "Здоровье" };
            Stat<string> newHealthStatus = Apply(newHealth, level => level >= 50 ? "в норме" : "на низком уровне!");

            Console.WriteLine("Значение Value новой структуры в обычном Stat:");
            Console.WriteLine(newHealth);
            Console.WriteLine();

            Console.WriteLine("Value новой структуры после перевода в string:");
            Console.WriteLine(newHealthStatus);
        }
    }
}


//| Вход | Ожидаемый результат |
//| Stat<int> { Value = 50, Name = "Здоровье" } → бонус +10 | Stat<int> со значением 60 |
//| то же значение → текстовый статус | Stat<string> со значением вроде "в норме" |


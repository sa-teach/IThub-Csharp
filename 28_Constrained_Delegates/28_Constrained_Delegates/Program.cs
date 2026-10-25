using System.Security.Cryptography.X509Certificates;

namespace _28_Constrained_Delegates
{
    internal class Program
    {
        public struct Stat<T> {
            public T Value;
            public string Name;
            public override string ToString() => $"{Name}: {Value}.";
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
            Stat<int> healthLevel = Apply(health, level => level + 10);

            Console.WriteLine("Значение Value в обычном Stat:");
            Console.WriteLine(health);
            Console.WriteLine();
            Console.WriteLine("Значение Value после прибавления бонуса:");
            Console.WriteLine(healthLevel);
            Console.WriteLine();

            Stat<string> healthStatus = Apply(health, level => level >= 50 ? "В норме" : "На низком уровне!");

            Console.WriteLine("Value после перевода в string:");
            Console.WriteLine(healthStatus);
        }
    }
}

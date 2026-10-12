namespace _1_NumbersProcessing
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            int factor = 2; // будем проверять делимость на это число
            int power = 2; // будем возводить в эту степень
            List<int> history = new List<int>();
            
            Console.WriteLine("Для начала нужно заполнить список.");
            List<int> numbers = Logic.AddToList();

            Func<int, bool> isEven = num => num % factor == 0;

            Func<int, int> squareNum = num => (int)Math.Pow(num, power);

            Action<int> reportMessage = result =>
            {
                Console.WriteLine($"[LOG] {result}");
                history.Add(result);
            };
           

            Console.WriteLine();
            Console.WriteLine($"Вывод чисел, делящихся нацело на {factor} и возведённых в {power}-ю степень:");
            foreach (int num in numbers)
            {
                if (isEven(num))
                {
                    reportMessage(squareNum(num));
                }
            }
            Console.WriteLine($"Количество записей в истории: {history.Count}");
        }
    }
}

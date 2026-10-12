namespace _2_MessagesProcessing
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            const int minLength = 3; // для поиска слов не короче трёх символов
            List<string> history = new List<string>();

            Console.WriteLine("Для начала нужно заполнить список.");
            List<string> messages = Logic.AddToList();            

            Func<string, bool> isValidLength = message => message.Length >= minLength;

            Func<string, string> messageToLog = message => $"[LOG] {message.ToUpper()}";

            Action<string> reportMessage = result =>
            {
                Console.WriteLine(result);
                history.Add(result);
            };

            Console.WriteLine();
            Console.WriteLine($"Вывод сообщений не короче {minLength} символов в верхнем регистре:");
            foreach (string msg in messages)
            {
                if (isValidLength(msg))
                {
                    reportMessage(messageToLog(msg));
                }
            }
            Console.WriteLine($"Количество записей в истории: {history.Count}");
        }
    }
}

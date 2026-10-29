namespace _31_GenericCollections
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            List<string> document = new List<string>();
            Queue<string> printQueue = new Queue<string>();
            Stack<string> undoHistory = new Stack<string>();

            void AddLine(string line)
            {
                document.Add(line);
                printQueue.Enqueue(line);
            }
            void Print()
            {
                if (printQueue.Count == 0)
                {
                    Console.WriteLine("Очередь печати пуста!");
                    return;
                }
                string line = printQueue.Dequeue();
                Console.WriteLine($"Распечатано: {line}");
            }
            void Delete()
            {
                int index = document.Count - 1;
                undoHistory.Push(document[index]);
                document.RemoveAt(index);
            }
            void CancelDelete()
            {
                document.Add(undoHistory.Pop());
            }

            AddLine("aaa");
            AddLine("bbb");
            AddLine("ccc");
            AddLine("ddd");

            Console.WriteLine("Весь документ");
            foreach (string line in document) Console.Write(line + ' ');
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Распечатали 2 строки в порядке постановки");
            Print();
            Print();            
            Console.WriteLine();

            Delete();
            Console.WriteLine("Удалили последнюю строку");
            foreach (string line in document) Console.Write(line + ' ');
            Console.WriteLine();

            Console.WriteLine("Последняя удалённая строка: " + undoHistory.Peek());
            Console.WriteLine();

            CancelDelete();
            Console.WriteLine("Вернули последнюю удаленную строку");
            foreach (string line in document) Console.Write(line + ' ');
            Console.WriteLine();
            try{ Console.WriteLine(undoHistory.Peek()); }
            catch { Console.WriteLine("Стек пуст!"); };
        }
    }
}

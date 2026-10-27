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

            Print();
            Delete();
            foreach (string line in document) Console.Write(line + ' ');
            Console.WriteLine();
            Console.WriteLine(undoHistory.Peek());

            CancelDelete();
            foreach (string line in document) Console.Write(line + ' ');
            Console.WriteLine(undoHistory.Peek());
        }
    }
}

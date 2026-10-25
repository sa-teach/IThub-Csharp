namespace _29_Constrained_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InMemoryRepository<Product> p = new InMemoryRepository<Product>();
            p.Add(new Product("Хлебушек", 50));
            Console.WriteLine(p.GetById(1));


        }
    }
}

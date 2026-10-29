namespace _29_Constrained_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InMemoryRepository<Product> p = new InMemoryRepository<Product>();
            InMemoryRepository<Customer> c = new InMemoryRepository<Customer>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ──────────────────────────────────────────────┐");
                Console.WriteLine("|  1 - добавить продукт в список InMemoryRepository<Product>        |");
                Console.WriteLine("|  2 - добавить пользователя в список InMemoryRepository<Customer>  |");
                Console.WriteLine("|  3 - найти продукт по id                                          |");
                Console.WriteLine("|  4 - найти пользователя по id                                     |");
                Console.WriteLine("|  5 - вывести все продукты                                         |");
                Console.WriteLine("|  6 - вывести всех пользователей                                   |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ                         |");
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Logic.FillList(p, Logic.CreateProduct);
                        break;

                    case "2":
                        Logic.FillList(c, Logic.CreateCustomer);
                        break;

                    case "3":
                        Console.Write("Введите id: ");
                        Product product = p.GetById(Logic.SafeInputInt());
                        Console.WriteLine(product == null ? "null" : product.ToString());
                        break;

                    case "4":
                        Console.Write("Введите id: ");
                        Customer customer = c.GetById(Logic.SafeInputInt());
                        if (customer == null)
                        {
                            Console.WriteLine("null");
                        }
                        else
                        {
                            Console.WriteLine(customer);
                        }
                        break;

                    case "5":
                        p.PrintItems();
                        break;

                    case "6":
                        c.PrintItems();
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

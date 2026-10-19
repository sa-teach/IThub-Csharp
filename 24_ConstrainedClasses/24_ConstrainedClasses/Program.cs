namespace _24_ConstrainedClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory<Weapon> weapons = new Inventory<Weapon>();
            Inventory<Potion> potions = new Inventory<Potion>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("┌─ Выберите действие  ────────────────────────┐");
                Console.WriteLine("|  1 - Заполнить список с оружием             |");
                Console.WriteLine("|  2 - Заполнить список с зельями             |");
                Console.WriteLine("|  3 - Вывести описание оружия                |");
                Console.WriteLine("|  4 - Вывести описания зелий                 |");
                Console.WriteLine("|  5 - Вывести общую стоимость оружия         |");
                Console.WriteLine("|  6 - Вывести общую стоимость зелий          |");
                Console.WriteLine("|  Чтобы выйти, введите любой другой символ   |");
                Console.WriteLine("└─────────────────────────────────────────────┘");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Logic.FillList(weapons, Logic.WeaponCreate);
                        break;

                    case "2":
                        Logic.FillList(potions, Logic.PotionCreate);
                        break;

                    case "3":
                        if (weapons.Count() == 0) Console.WriteLine("Список пуст.");
                        else
                        {
                            Console.WriteLine("Описание оружия из инвентаря:");
                            weapons.PrintAll();
                        }
                        break;

                    case "4":
                        if (potions.Count() == 0) Console.WriteLine("Список пуст.");
                        else
                        {
                            Console.WriteLine("Описание зелий из инвентаря:");
                            potions.PrintAll();
                        }                        
                        break;

                    case "5":
                        if (weapons.Count() <= 0) Console.WriteLine("Список пуст.");
                        else Console.WriteLine("Общая стоимость оружия: " + weapons.GetTotalValue());
                        break;

                    case "6":
                        if (potions.Count() <= 0) Console.WriteLine("Список пуст.");
                        else Console.WriteLine("Общая стоимость зелий: " + potions.GetTotalValue());
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

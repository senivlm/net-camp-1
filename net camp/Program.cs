using net_camp.Products;
using System;

namespace net_camp
{
    internal class Program
    {//реорганізувати структуру папок!!!
        static void Main(string[] args)
        {
            Storage storage = new Storage();

            AddProduct(storage);
            AddProduct(storage);
            storage.GetAll();

            void AddProduct(Storage storage)
            {
                Console.WriteLine("0 to add Meat, 1 to add Dairy");
                string res = Console.ReadLine();
                switch (res)
                {
                    case "0":
                        Meat meat = new Meat();
                        Console.WriteLine("name:");
                        meat.Name = Console.ReadLine();
                        Console.WriteLine("price:");
                        meat.Price = int.Parse(Console.ReadLine());
                        Console.WriteLine("weight:");
                        meat.Weighth = float.Parse(Console.ReadLine());
                        Console.WriteLine("type:");
                        int categ = int.Parse(Console.ReadLine());
                        meat.category = (Meat.Category)categ;
                        Console.WriteLine("type:");
                        int type = int.Parse(Console.ReadLine());
                        meat.type = (Meat.Type)type;
                        storage.AddProduct(meat);
                        break;

                    case "1":
                        Dairy dairy = new Dairy();
                        Console.WriteLine("name:");
                        dairy.Name = Console.ReadLine();
                        Console.WriteLine("price:");
                        dairy.Price = int.Parse(Console.ReadLine());
                        Console.WriteLine("weight:");
                        dairy.Weighth = float.Parse(Console.ReadLine());
                        Console.WriteLine("expires in:");
                        int exp = int.Parse(Console.ReadLine());
                        dairy.expires_in = exp;
                        storage.AddProduct(dairy);
                        break;
                }
            }
        }
    }

}

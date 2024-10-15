

using System.Diagnostics;
using System.Xml.Linq;

namespace CompStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook Acer = new Notebook("Asus", "Gaming", 7, 4500, 32, 512);
            Acer.ShowFullData();
            Notebook Hp = new Notebook("Hp", "Office", 16, 1200, 8, 256);
            Hp.ShowFullData();
            Notebook Lenovo = new Notebook("Lenovo", "Office" , 30, 1000, 16, 512);
            Lenovo.ShowFullData();
        }
        class Product
        {
            public string Name;
            public string Description;
            public int Count;
            public bool IsStock;
            public double Price;

            public Product(string name, string description, int count, double price)
            {
                Name = name;
                Description = description;
                Count = count;
                Price = price;
            }
        
            public void ShowFullData()
            {
                Console.WriteLine($"Name:{Name},Description:{Description},Price:{Price},Count:{Count},Price:{Price}");
            }

        }
        class Notebook : Product
        {
            public byte Ram;
            public int Storage;
            public Notebook(string name, string description, int count, double price, byte ram, int storage) : base(name, description, count, price)
            {
               
                if (count == 0)
                {
                    Console.WriteLine("Mehsul stokda yoxdu");
                }
                Ram = ram;
                Storage = storage;

            }
            public void ShowFullData()
            {
                base.ShowFullData();
                Console.WriteLine($"Ram:{Ram},Storage:{Storage}");
            }

        }
    }
}

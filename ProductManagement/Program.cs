using System;

namespace ProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Shop s = new Shop();
            int choice = 0;
            do
            {
                Console.WriteLine("1.Add new Products");
                Console.WriteLine("2.Remove Product ");
                Console.WriteLine("3.View Product ");
                Console.WriteLine("4.Serch Product ");
                Console.WriteLine("5.Exit ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        s.Addproduct();
                        break;
                    case 2:
                        s.RemoveProduct();
                        break;
                    case 3:
                        s.ViewProduct();
                        break;
                    case 4:
                        s.SerchProduct();
                        break;
                    case 5:
                        return;

                }
            } while (choice != 5);
        }
    }
}
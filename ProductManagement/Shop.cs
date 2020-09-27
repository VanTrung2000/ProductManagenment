using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProductManagement
{
    class Shop
    {
        int count = 0;
        Dictionary<int, object> ListProduct = new Dictionary<int, object>();
        
        public void Addproduct()
        {
           
            Product po = new Product();
            Console.WriteLine("Nhap name :");
            po.Name = Console.ReadLine();
            Console.WriteLine("Nhap Description :");
            po.Description = Console.ReadLine();
            do
            {
            Console.WriteLine("Nhap Price:");
            po.Price = double.Parse(Console.ReadLine());
            } while (!(po.Price > 0 && po.Price < 100));
            Console.WriteLine("Number of rate:");
            int N = int.Parse(Console.ReadLine());
            po.Rate = new int [N];
            for (int i = 0; i < N; i++)
            {
                do
                {
                    Console.WriteLine("Rate:" + (i + 1) + ":");
                    po.Rate[i] = int.Parse(Console.ReadLine());
                } while (!(po.Rate[i] >= 1 && po.Rate[i] <= 5));

            }
            ListProduct.Add(count,po);
            count++;
            

        }
        public void ViewProduct()
        {
            foreach(Product item in ListProduct.Values)
            
                item.Viewinfo();
            
        }
        public void SerchProduct()
        {

            double minPrice;
            double maxPrice;
            bool search = false;
            do
            {
                Console.Write("Please enter Min price: ");
                minPrice = double.Parse(Console.ReadLine());
            } while (!(minPrice > 0 && minPrice <= 100));
            do
            {
                Console.Write("Please enter Max price: ");
                maxPrice = double.Parse(Console.ReadLine());
            } while (!(minPrice <= 100 && maxPrice > minPrice));

            foreach (Product item in ListProduct.Values)
            {
                if (item.Price >= minPrice && item.Price <= maxPrice)
                {
                    search = true;
                    item.Viewinfo();
                }
                }

            if (search == false)
            {
                Console.WriteLine("Loi!");
            }

            }
        public void RemoveProduct()
        {
            int count = 0;
            bool search = false;
            Console.WriteLine("Nhap ten muon xoa:");
            string name = Console.ReadLine();
            foreach (Product item in ListProduct.Values)
            {
                if ( name.Equals(item.Name))
                {
                    search = true;
                    ListProduct.Remove(count);
                    break;
                }
            }
            if (search == true)
                Console.WriteLine("Xoa thanh cong");
            else
                Console.WriteLine("Loi");

        }
        }
    }


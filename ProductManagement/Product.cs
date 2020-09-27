using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement
{
    class Product
    {
        public string Name { set; get; }
        public string Description { set; get; }
        public double Price { set; get; }
        public int [] Rate { set; get; }

        public void Viewinfo()
        {
            Console.WriteLine("Name:" + Name + " Price: " + Price + " Description: " + Description);
        }
    }
}

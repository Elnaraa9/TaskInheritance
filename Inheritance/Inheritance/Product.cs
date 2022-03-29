using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Product
    {
        public int No;
        public string Name;
        public double Price;
  
        public Product()
        {
            Console.WriteLine("Book created");
        }
        public Product(string name,int no)
        {
            No = no;
            Name = name;
        }
        public Product(string name,double price,int no):this(name,no)
        {
            Price = price;
        }
        public virtual void Info()
        {
            Console.WriteLine($"No={No},Name-{Name},Price-{Price}");
        }
    }
}

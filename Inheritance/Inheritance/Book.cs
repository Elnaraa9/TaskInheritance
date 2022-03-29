using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Book:Product
    {
        public string Author;
        public Book(string name,double price,int no,string author):base(name,no)
        {
            Author = author;
        }
        public override void Info()
        {
            Console.WriteLine($"No={No},Name-{Name},Price-{Price},Author-{Author}");
        }
    }
}

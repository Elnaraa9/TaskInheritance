using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car("Kia","Optima","blue",210);
            //car.Info();
            //Car bus = new Bus("Tata","Magna","white",180,16);
            //bus.Info();
            Product product = new Product("C#",23,645321);
            product.Info();
            Product book = new Product("Abdc",12,96875);
            book.Info();
        }
    }
}

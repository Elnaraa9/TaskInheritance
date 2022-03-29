using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Car
    {
        public string brand;
        public string model;
        public string color;
        public double maxSpeed;

        public virtual void Info()
        {
            Console.WriteLine($"Brand-{brand} Model-{model} Color-{color} MaxSpeed-{maxSpeed}");
        }
        public Car()
        {
            Console.WriteLine("Car created");
        }
        public Car(string brand,string model)
        {
            this.brand = brand;
            this.model = model;
        }
        public Car(string brand,string model,string color,double maxSpeed):this(brand,model)
        {
            this.color = color;
            this.maxSpeed = maxSpeed;
        }
    }
}

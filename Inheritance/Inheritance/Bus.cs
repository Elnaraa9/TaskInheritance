using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bus:Car
    {
        public int passengerCount;
      
        public Bus(string brand,string model,string color,double maxSpeed,int passengerCount):base(brand,model,color,maxSpeed)
        {
            this.passengerCount = passengerCount;
        }
        public override void Info()
        {
            Console.WriteLine($"Brand-{brand} Model-{model} Color-{color} MaxSpeed-{maxSpeed} PassengerCount-{passengerCount}");
        }
    }
}

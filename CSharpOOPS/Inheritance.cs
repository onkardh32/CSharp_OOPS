using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOPS
{
    internal class Inheritance
    {
    }
    class BaseModel
    {
        public int speed = 120;
        public int wheels = 4;
        public int seats = 4;
        public void getDetails() {
            Console.WriteLine("The based model contains : "+wheels+" Wheels "+seats+" Seats "+" With top speed :"+speed);
        }


    }

    class Thar : BaseModel
    {
        public int engineCC=2000;
        public int buildYear = 2024;
        public string modelName = "Thar";
        public int speed = 200;
        public int wheels = 4;
        public int seats = 6;
        public void getTharFeatures()
        {
            Console.WriteLine("Thar was launched in "+buildYear+" With engine capacity "+engineCC);
            Console.WriteLine("Capacity : " + seats + " seats," + " Top speed : " + speed);
        }

    }
}

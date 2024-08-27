using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOPS
{
    internal class Interface
    {
    }
    interface IBike
    {
        void bikeSound();
        void bikeEngine();
    }
    class Splendor : IBike
    {
        public void bikeSound()
        {
            Console.WriteLine("The splendor has smooth sound ");
        }
        public void bikeEngine()
        {
            Console.WriteLine("Spendor has 100cc engine ");
        }
    }

}

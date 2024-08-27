using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOPS
{
    internal class Abstraction
    {
    }
    // cannot creat the object and methods must be overriden 
    abstract class Bird
    {
        public abstract void birdSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    class Peacock : Bird
    {
        public override void birdSound()
        {
           
            Console.WriteLine("The peacock says: wee wee");
        }
    }
}

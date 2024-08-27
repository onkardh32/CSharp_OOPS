using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOPS
{
    internal class Polymorphism
    {
    }
    class Animal  
    {
        public virtual void  animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Parrot : Animal  
    {
        public override void animalSound()
        {
            Console.WriteLine("The parrot makes : chirp chirp ");
        }
    }

    class Dog : Animal   
    {
        public  override void animalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }
}

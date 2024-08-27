using System;
using System.Net.NetworkInformation;

namespace CSharpOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // class : a bundle or related code 
            //         can be used as blueprint to create the objects (OOP)


            // Objects : instance of a class (fields & methods ).




            /*
            Car car1 = new Car("Ford","Mustang",2022,"Red","Rohit Pandey");
            car1.getOwner(9090);
            car1.getInfo();

            Car.getTotalCars();

            Thar c1 = new Thar();
            c1.getTharFeatures();

            
             
              
             */


            /*
             // abstracion
            Animal animal = new Animal();
            Animal parrot=new Parrot();
            Animal dog = new Dog();

            animal.animalSound();
            parrot.animalSound();
            dog.animalSound();
            */

            /*
             //Interfaces
            Splendor spl= new Splendor();
            spl.bikeSound();

            */
            
            Peacock myPk = new Peacock();
            myPk.birdSound();
            

        }



    }
   

     
}

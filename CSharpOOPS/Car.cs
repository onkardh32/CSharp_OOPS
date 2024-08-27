using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOPS
{
    class Car
    {
        String make;
        String model;
        int year;
        String color;
        private String ownerName;

        
        // static members
        public static int totalCars=0;

        // Constructor

        // Constructor overaloading
        // Default Constructor
        public Car()
        {
            this.make = "TATA";
            this.model = "Punch";
            this.year = 2000;
            this.color = "Black";
            this.ownerName = "Admin";
        }
        // parameterized constructor
        public Car(String make, String model, int year, String color,String owner)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            this.ownerName = owner;
            totalCars++;
        }

       

        // getter
        public void getOwner(int PIN)
        {
            {
                if (PIN == 9090)
                {
                    Console.WriteLine("You have successfully logged in ");
                    Console.WriteLine(ownerName + " Owns this car " );
                }
            }
        }
        // setter
        public void changeOwner(int OTP)
        {
            Console.WriteLine("Enter New Owners Name : ");
            String newOwnerName = Console.ReadLine();
            this.ownerName = newOwnerName;
        }
        public void getInfo()
        {
            Console.WriteLine("Car Name : "+make+" "+model);
            Console.WriteLine("Was Built in : " + year);
            Console.WriteLine("Color it has : " + color);

        }

        // static method getter
        public static void getTotalCars()
        {
            Console.WriteLine("The total cars are : "+totalCars);
        }
    }
}

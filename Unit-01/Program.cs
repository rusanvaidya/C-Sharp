using System;

namespace Unit_1
{
    class VendingMachine
    {
        //Class fields
        public static int Count = 30; // STatic
        public int Capacity = 100; //Non-static
        public int MoneyCollected = 300;
        
        // readonly field of manufacturer = "Vendy Inc."
        // Now manufacturer of the machine can nerver be changed
        // to some other value throught the program
        public readonly string Manufacturer = "Vendy Inc.";


        //Class Methods
        public void Display()
        {
            Console.WriteLine("Count is : {0}", Count);
        }
        public void DispenseProducts()
        {
            Console.WriteLine("I am the DispenseProducts method for dispensing the products!");
        }
        public void Refill()
        {
            Console.WriteLine("I am the Refill method for refilling the products!");
        }

    }

    class Demo //Class containing the Main() method
    { 
        public static void Main(string[] args)
        {
            var vendingMachine = new VendingMachine(); //Object creation
            //Calling the members of the VendingMachine class                                           
            Console.WriteLine("The capacity of the machine is: {0}", vendingMachine.Capacity);
            vendingMachine.Display();
        }
    }
}

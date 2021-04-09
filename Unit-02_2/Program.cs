using System;

namespace Unit_02_2
{
    class VendingMachine {
  
        //no fields declared
        // Implementing the auto-implemented property for count
        public int Count {get; set;}
    }

    class Demo {
  
        public static void Main(string[] args) {
        var vendingMachine = new VendingMachine();
        vendingMachine.Count = 88; // setting the count using Count property
        Console.WriteLine("The count is: {0}", vendingMachine.Count); // getting the count using Count property
        }    
    }
}

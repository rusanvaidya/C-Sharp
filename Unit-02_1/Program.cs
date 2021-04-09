using System;

namespace Unit_02_1
{
// VendingMachine class
class VendingMachine {
  
  private int _count = 0; // member field count
  private int _capacity = 100;

  // Implementing the count property 
  public int Count {
    get { //for getting value
      return _count;
      }
    set { //for setting value
      if (value >= 0 && value <= _capacity)
      _count = value;
      }
  } 
  
}

class Demo {
  
   public static void Main(string[] args) {
     var vendingMachine = new VendingMachine();
     vendingMachine.Count = 88; // setting the count using Count property
     Console.WriteLine("The count is: {0}", vendingMachine.Count); // getting the count using Count property
   } 
  }
}
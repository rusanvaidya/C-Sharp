using System;

namespace Unit_02
{
    // VendingMachine class
class VendingMachine {
  
  private int _count; // member field count
  private int _capacity = 100;

  // Setter method to set the count of the products
  public void SetCount(int x) {
    if(x >=0 && x <= _capacity) { // count should always be positive and less than or equal to capacity
    _count = x; 
    }
  }

  // Getter method to get the count of the products
  public int GetCount() {
    return _count; 
  }
  
}

class Demo {
  
   public static void Main(string[] args) {
     var vendingMachine = new VendingMachine();
     vendingMachine.SetCount(88); // calling the setter method
     Console.WriteLine("The count is: {0}", vendingMachine.GetCount()); // calling the getter method
   } 
  
}
}

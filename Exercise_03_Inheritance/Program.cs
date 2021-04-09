using System;

namespace Exercise_03_Inheritance
{
   // Base Class
class Laptop {

  // Private Data Members
  public string Name{get; set;}

  public Laptop() { // Default Constructor
  
  }

  public Laptop(string name) { // Default Constructor
    this.Name = name;  
  }

}

// Derived Class
class Dell : Laptop { 
  public Dell(string name) 
  : base(name)
  { 

  }

}

class Demo {
  public static void Main(string[] args) {
   Dell dell = new Dell("Dell Inspiron");
   Console.WriteLine(dell.Name);
    
  }
} 
}

using System;

namespace Unit_06_Interface
{
        // Addition interface
    interface IAddition 
    {
        int AddTwo(int num1, int num2);
    }

    // Calculator Class Implementing the Addition Interface
    class Calculator : IAddition {
    
        // Overriding the add method of Addition interface
        public int AddTwo(int num1, int num2) 
        {
            return num1 + num2;
        }
    
    }

    class Demo {
        public static void Main(string[] args) {
        Calculator cal = new Calculator();
        Console.WriteLine(cal.AddTwo(10, 20));
        }
    }  
}

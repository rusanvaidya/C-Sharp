/*
abstract method can be declared inside an abstract class or an interface only
one cannot create an object of an abstract class
*/
using System;

namespace Unit_06_Abstraction
{
    abstract class Program
    {
        public abstract void show();
    }

    class Program2 :Program
    {
        public override void show()
        {
            Console.WriteLine("Hello World");
        }
    }

    class Demo
    {
        public static void Main(String[] args)
        {
            Program2 p = new Program2();
            p.show();
        }
    }
}

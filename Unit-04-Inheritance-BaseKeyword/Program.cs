using System;

namespace Unit_04_Inheritance_BaseKeyword
{
    class Base_A
    {
        public double pi = 3.14159;
        public void calc(int r)
        {
            Console.WriteLine("Area of circle is with base method : "+ pi *r*r);
        }
    }

    class Child_B : Base_A
    {
        public double pi = 22/7;
        public void calc(int r)
        {
            // Pie from base
            Console.WriteLine("Area of circle is with base pi : "+ base.pi *r*r);
            // Pie from child
            Console.WriteLine("Area of circle is with this pi : " + this.pi *r*r);
        }

        public void Print()
        {
            // Display form base 
            base.calc(4);

            // Display from child
            calc(4);
        }
        
    }

    class Demo
    {
        static void Main(string[] args)
        {
            Child_B b = new Child_B();
            b.Print();
        }
    }
}

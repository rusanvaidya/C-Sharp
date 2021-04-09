using System;

namespace Examples
{
    class Program
    {
        public int Min(int a, int b)
        {
            return Math.Min(a,b);
        }
        public double Power(int a,int b)
        {
            return Math.Pow(a,b);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Minimum value : " + p.Min(1,5));
            Console.WriteLine("Base and Power : " + p.Power(2,3));
        }
    }
}

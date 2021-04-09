using System;

namespace Exercise_01
{
    class SumOfSquares {
            
        // Method to square the sum of three numbers
        public double SquaresSum(double num1, double num2, double num3) {
            double sum = 0;
            double num1sqr,num2sqr,num3sqr;
            num1sqr = num1*num1;
            num2sqr = num2*num2;
            num3sqr = num3*num3;
            sum = num1sqr+num2sqr+num3sqr;
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SumOfSquares ss = new SumOfSquares();
            Console.WriteLine("The result is {0}", ss.SquaresSum(2, 3, 4));
        }
    }
}

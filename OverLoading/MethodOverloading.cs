using System;
namespace OverLoading
{
    public class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition of Integers..."+ (a+b));
        }

        public void Add(double a, double b)
        {
            Console.WriteLine("Additon of Double.."+(a+b));
        }
    }
}




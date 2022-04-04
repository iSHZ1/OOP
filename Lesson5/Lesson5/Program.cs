using System;
using System.Globalization;

namespace Lesson5
{
    class Program
    {
        static void Main()
        {
            double a = 3.556;
            double b = 5.555;
            RationalNumber a1 = new RationalNumber(a);
            RationalNumber b1 = new RationalNumber(b);

            a1.PrintInfo();
            Console.WriteLine(a1.ToString()); 
            a1.PrintInfo();

            if (a1 > b1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("Not");
            }

            RationalNumber c1 = a1 + b1;

            c1.PrintInfo();

            c1 = a1 * b1;

            c1.PrintInfo();
            c1.ToString();
        }
    }
}
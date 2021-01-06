using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 2;
            Console.WriteLine("a + b = {0}", a + b);   // 13
            Console.WriteLine("a / b = {0}", a / b);   // 3 > because a, b are int
            Console.WriteLine("(float)a / (float)b = {0}", (float)a / (float)b);     // 3.333333     using casting
            Console.WriteLine("a + b * c = {0}", a + b * c);        // 16
            Console.WriteLine("(a + b) * c = {0}", (a + b) * c);    // 26
            Console.WriteLine("a > b is {0}", a > b);       // True
            Console.WriteLine("a == b is {0}", a == b);     // False
            Console.WriteLine("a > b && b > c is {0}", a > b && b > c);     // True
            Console.WriteLine("a > b && b < c is {0}", a > b && b < c);     // False
            Console.WriteLine("a > b || b < c is {0}", a > b || b < c);     // True
        }
    }
}

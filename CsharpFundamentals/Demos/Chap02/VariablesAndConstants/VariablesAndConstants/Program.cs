using System;
using System.Runtime.InteropServices;

namespace VariablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        { 
            var number = 2;             // 기본 type int
            var count = 10;
            var totalPrice = 20.59f;
            var character = 'A';
            var firstName = "jaehyun";
            var isTrue = false;

            /* 타입을 지정해주는 경우
            byte number = 2;
            int count = 10;
            float totalPrice = 20.59f;
            char character = 'A';       // single quote
            string firstName = "jaehyun";    // double quote
            bool isTrue = false;
            */

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isTrue);

            // 
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);     // {0}: first arg  {1}: second arg
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            /* Contants
            const float Pi = 3.14f;
            Pi = 1;     // Readonly
            */
        }
    }
}

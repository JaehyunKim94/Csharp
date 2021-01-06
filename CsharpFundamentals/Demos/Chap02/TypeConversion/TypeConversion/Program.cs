using System;
using System.Runtime.InteropServices;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            // byte b = i;         // Cannot convert source type 'int' to target type 'byte'
            byte b = (byte)i;   // Use casting
            Console.WriteLine(b);   // 1

            // data loss
            int j = 1000;
            byte a = (byte) j;
            Console.WriteLine(a);   // 232

            /*
            // How to handle exception
            try
            {
                var number = "1234";
                // int i = (int) number;   // Cannot cast expression of type 'string' to 'int'
                byte y = Convert.ToByte(number);
                Console.WriteLine(y);   // System Overflow Exception: Too large for byte
            }
            catch (Exception)
            {
                Console.WriteLine("Error: The number could not be converted to a byte.");
                //throw; // show Error
            }
            */
        }
    }
}

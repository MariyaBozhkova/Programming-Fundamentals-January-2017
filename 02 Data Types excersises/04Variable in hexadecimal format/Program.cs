using System;


namespace _04Variable_in_hexadecimal_format
{
    class Program
    {
        static void Main(string[] args)
        {
            var hexadecimalNumber = Console.ReadLine();
            int decimalNumber = Convert.ToInt32(hexadecimalNumber, 16);
            Console.WriteLine(decimalNumber);
        }
    }
}

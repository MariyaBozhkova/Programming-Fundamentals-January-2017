using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Integer_to_hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {

            int integer = int.Parse(Console.ReadLine());
            string hexadecimal = integer.ToString("X");
            string binary = Convert.ToString(integer, 2);
            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}


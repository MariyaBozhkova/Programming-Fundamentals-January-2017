using System;


namespace _04_Variable_in_hexadecimal_format
{
    class Program
    {
        static void Main(string[] args)
        {
            string Value = "0xFE";
            try
            {
                int number = Convert.ToInt32(Value);
                Console.WriteLine(number);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Unable to convert to integer");
            }
        }
    }
}

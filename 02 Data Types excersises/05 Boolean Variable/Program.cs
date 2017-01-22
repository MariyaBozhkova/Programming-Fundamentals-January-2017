using System;


namespace _05_Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = Console.ReadLine();
            bool convert = (Convert.ToBoolean(string1));
            if (convert == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

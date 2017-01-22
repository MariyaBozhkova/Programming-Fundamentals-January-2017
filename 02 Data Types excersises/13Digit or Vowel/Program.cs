using System;


namespace _13Digit_or_Vowel
{
    public class Program
    {
       public static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            if (input=='a' || input=='e' || input =='o' || input =='i' || input=='u' || input == 'y'|| input == 'A' || input == 'E' || input == 'O' || input == 'I' || input == 'U' || input == 'Y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}

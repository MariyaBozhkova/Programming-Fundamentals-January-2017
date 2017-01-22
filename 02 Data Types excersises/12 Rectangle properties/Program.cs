using System;


namespace _12_Rectangle_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            double diagonal = Math.Sqrt(height * height + width * width);
            Console.WriteLine($"{perimeter} \n{area} \n{diagonal}");
        }
    }
}

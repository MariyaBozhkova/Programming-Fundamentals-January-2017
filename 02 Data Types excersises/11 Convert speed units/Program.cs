using System;

namespace _11_Convert_speed_units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMetres = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float totSeconds = (hours * 60 + minutes) * 60 + seconds;
            float Vms = (float)(distanceInMetres / totSeconds);
            float Vkmh = (float)(Vms * 3.6);
            float Vmh = (float)(Vkmh / 1.609);
            Console.WriteLine($"{Vms} \n{Vkmh} \n{Vmh}");
        }
    }
}

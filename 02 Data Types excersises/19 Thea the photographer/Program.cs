using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Thea_the_photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double photosTaken = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double filterFaktor = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());
            double goodPhotos = Math.Ceiling(photosTaken * filterFaktor / 100);
            double totSeconds = photosTaken * filterTime + goodPhotos * uploadTime;
            double days = Math.Floor(totSeconds / (3600 * 24));
            double hours = Math.Floor((totSeconds - days * 3600 * 24) / 3600);
            double minutes = Math.Floor((totSeconds - hours * 3600 - days * 3600 * 24) / 60);
            double seconds = totSeconds - hours * 3600 - minutes * 60 - days * 3600 * 24;
            Console.WriteLine($"{days}:{hours}:{minutes}:{seconds}");           
        }
    }
}

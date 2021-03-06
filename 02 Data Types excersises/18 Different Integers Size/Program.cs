﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18_Different_Integers_Size
{

    class TheaPhotographer
    {
        static void Main(string[] args)
        {
            int allPicturesTaken = int.Parse(Console.ReadLine());
            int filterPictures = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());
            long usefulPictures = (long)Math.Ceiling(allPicturesTaken * (filterFactor / 100.0));
            long filterTime = (long)allPicturesTaken * filterPictures;
            long alltime = filterTime + (usefulPictures * uploadTime);
            TimeSpan Time = TimeSpan.FromSeconds(alltime);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", Time.Days, Time.Hours, Time.Minutes, Time.Seconds);

        }
    }
}

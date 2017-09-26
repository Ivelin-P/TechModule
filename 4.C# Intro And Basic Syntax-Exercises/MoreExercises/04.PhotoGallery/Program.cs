using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            string orentation;
            double sizeCalc = 0.0;
        
            if (width > hight)
            {
                orentation = "landscape";               
            }
            else if (width == hight)
            {
                orentation = "square";
            }
            else
            {
                orentation = "portrait";
            }

            Console.WriteLine($"Name: DSC_{number:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hour:d2}:{minute:d2}");

            if (size < 1000)
            {              
                Console.WriteLine($"Size: {size}B");
            }
            else if (size > 1000 && size < 1000000)
            {
                sizeCalc = size / 1000;
                Console.WriteLine($"Size: {sizeCalc}KB");
            }
            else if (size >= 1000000)
            {
                sizeCalc = size / 1000000;
                Console.WriteLine($"Size: {sizeCalc}MB");
            }
                       
            Console.WriteLine($"Resolution: {width}x{hight} ({orentation})");
        }
    }
}

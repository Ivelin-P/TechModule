using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double resolution = (width * hight) / 1000000;

            Console.WriteLine($"{width}x{hight} => {Math.Round(resolution, 1)}MP");
        }
    }
}

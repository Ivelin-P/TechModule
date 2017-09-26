using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{(volume / 100) * energy}kcal, {(volume / 100) * sugarContent}g sugars");
        }
    }
}

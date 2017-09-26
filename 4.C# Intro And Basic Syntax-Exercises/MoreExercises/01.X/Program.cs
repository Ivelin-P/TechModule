using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int midspaces = n - 2;
            int frontEndSpaces = n - (midspaces + 2);

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(' ', frontEndSpaces));
                Console.Write("x");
                Console.Write(new string(' ', midspaces));
                Console.Write("x");
                Console.WriteLine(new string(' ', frontEndSpaces));
                midspaces -= 2;
                frontEndSpaces++;
            }

            Console.Write(new string(' ', frontEndSpaces));
            Console.Write("x");
            Console.WriteLine(new string(' ', frontEndSpaces));
            frontEndSpaces--;
            midspaces += 2;

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(' ', frontEndSpaces));
                Console.Write("x");
                Console.Write(new string(' ', midspaces));
                Console.Write("x");
                Console.WriteLine(new string(' ', frontEndSpaces));
                midspaces += 2;
                frontEndSpaces--;
            }
        }
    }
}

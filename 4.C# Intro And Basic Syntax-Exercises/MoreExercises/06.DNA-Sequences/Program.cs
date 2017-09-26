using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int firstLetter = 1; firstLetter <= 4; firstLetter++)
            {
                for (int secoundLetter = 1; secoundLetter <= 4; secoundLetter++)
                {
                    for (int thirdLetter = 1; thirdLetter <= 4; thirdLetter++)
                    {
                        count++;
                        sum = firstLetter + secoundLetter + thirdLetter;
                        if (sum >= n)
                        {
                            Console.Write("O" + ("" + firstLetter + secoundLetter + thirdLetter).Replace('1', 'A')
                                  .Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "O ");
                        }
                        else
                        {
                            Console.Write("X" + ("" + firstLetter + secoundLetter + thirdLetter).Replace('1', 'A')
                                    .Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                        }

                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}

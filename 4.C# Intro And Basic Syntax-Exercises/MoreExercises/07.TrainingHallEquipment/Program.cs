using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int itemsCount = int.Parse(Console.ReadLine());

            double subtotal = 0.0;

            for (int i = 1; i <= itemsCount; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                double totalPrice = price * count;
                subtotal += totalPrice;

                if (count > 1)
                {
                    Console.WriteLine($"Adding {count} {name}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {count} {name} to cart.");
                }           
            }

            double moneyLeft = budget - subtotal;
            double moneyNeeded = subtotal - budget;

            if (subtotal <= budget)
            {
                Console.WriteLine($"Subtotal: ${subtotal:f2}");
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${subtotal:f2}");
                Console.WriteLine($"Not enough. We need ${moneyNeeded:f2} more.");
            }
        }
    }
}

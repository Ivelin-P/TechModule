using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double startBudget = budget;
            double currentPrice = 0.0;
            bool chek = false;

            string game = Console.ReadLine();


            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        currentPrice = 39.99;
                        break;
                    case "CS: OG":
                        currentPrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        currentPrice = 19.99;
                        break;
                    case "Honored 2":
                        currentPrice = 59.99;
                        break;
                    case "RoverWatch":
                        currentPrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        currentPrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");                                              
                        break;
                }              
                if (currentPrice > budget)
                {
                    Console.WriteLine("Too Expensive");
                    currentPrice = 0;                  
                }
                else if (currentPrice != 0)
                {
                    Console.WriteLine("Bought " + game);
                    budget -= currentPrice;
                    currentPrice = 0;                   
                }
                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    chek = true;
                    break;
                }
                game = Console.ReadLine();               
            }
            if (chek != true)
            {
                Console.WriteLine($"Total spent: ${(startBudget - budget):f2}. Remaining: ${budget:f2}");
            }            
        }
    }    
}


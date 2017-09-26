using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            double bpm = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4;
            double bps = 60 / bpm;
            double totalSecounds = bps * numberOfBeats;
            int minutes = (int)totalSecounds / 60;
            int secounds = (int)totalSecounds % 60;


            Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {secounds}s");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMStyping
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string message = String.Empty;

       
            

            for (int i = 1; i <= n; i++)
            {
                string digits = Console.ReadLine();
                int mainDigit = int.Parse(digits[0].ToString());
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                int letterIndex = (offset + digits.Length - 1);

                if (mainDigit == 0)
                {
                    message += " ";
                }
                else
                {
                    message += (char)(97 + letterIndex);
                }
            }
            Console.WriteLine(message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexiDecimal = Console.ReadLine();
            long numDec = 0;
            long power=1;
            int j = 0;
            for (int i = hexiDecimal.Length-1; i >=0; i--)
            {
                switch (hexiDecimal[i])
                {
                    case 'A': numDec += 10 * power; break;
                    case 'B': numDec += 11 * power; break;
                    case 'C': numDec += 12 * power; break;
                    case 'D': numDec += 13 * power; break;
                    case 'E': numDec += 14 * power; break;
                    case 'F': numDec += 15 * power; break;
                    default: numDec +=((int)hexiDecimal[i]-48)*power; break;
                }
                j++;
                power*=16;
            }
            Console.WriteLine(numDec);
        }
    }
}

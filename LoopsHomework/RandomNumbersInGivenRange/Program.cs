using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersInGivenRange
{
    class Program
    {
        //Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write(rnd.Next(min, max)+" ");
            }
        }
    }
}

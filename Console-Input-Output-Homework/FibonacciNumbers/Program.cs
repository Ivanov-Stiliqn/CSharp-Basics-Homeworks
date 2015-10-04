using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1) Console.WriteLine(0);
            int first = 0;
            int second = 1;
            int third = 0;
            Console.Write(first+" "+second+" ");
            for (int i = 2; i < n; i++)
            {
                third = first + second;
                Console.Write(third+" ");
                first = second;
                second = third;
            }
        }
    }
}

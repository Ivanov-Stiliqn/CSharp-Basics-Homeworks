using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class Program
    {
        //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 20)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + " ");
                    for (int j = i + 1; j < n + i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Vuvedi chislo <20");
        }
    }
}

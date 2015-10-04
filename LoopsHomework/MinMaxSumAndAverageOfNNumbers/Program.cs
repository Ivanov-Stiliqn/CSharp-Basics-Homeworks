using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
        //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("min = {0}",num.Min());
            Console.WriteLine("max = {0}",num.Max());
            Console.WriteLine("sum = {0}",num.Sum());
            Console.WriteLine("avg = {0:0.00}",num.Average());
        }
    }

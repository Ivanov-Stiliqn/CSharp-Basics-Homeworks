﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vuvedi chislo: ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum={0}",sum);
        }
    }
}

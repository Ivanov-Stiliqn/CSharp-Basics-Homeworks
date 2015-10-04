using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = double.MinValue;
            for (int i = 0; i < 5; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number > max)
                    max = number;
            }
            Console.WriteLine(max);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] number = numbers.Split(' ');
            double sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                double n = double.Parse(number[i]);
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}

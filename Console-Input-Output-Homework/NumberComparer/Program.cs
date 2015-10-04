using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double greater=(a+b+Math.Abs(a-b))/2;
            Console.WriteLine("Greater: {0}",greater);
        }
    }
}

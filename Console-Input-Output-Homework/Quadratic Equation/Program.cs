using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = 0;
            D = b * b - (4 * a * c);
            if(D==0)
                Console.WriteLine("x1=x2={0}",-b/(2*a));
            else if (D < 0)
                Console.WriteLine("no real roots");
            else
            {
                Console.Write("x1={0}", ((-b - Math.Sqrt(D)) / (2 * a)));
                Console.Write("; x2={0}", ((-b + Math.Sqrt(D)) / (2 * a)));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterandArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete radius: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter={0:F2}",Math.PI*2*r);
            Console.WriteLine("Area={0:F2}",Math.PI*r*r);
        }
    }
}

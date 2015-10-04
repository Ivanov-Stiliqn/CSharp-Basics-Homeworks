using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p;
            if(a<c)
            {
                p =a;
                a = c;
                c = p; 
            }
            if(a<b)
            {
                p = a;
                a = b;
                b = p;
                if(b<c)
                {
                    p = b;
                    b = c;
                    c = p;
                }
            }
            Console.WriteLine("{0} {1} {2}",a,b,c);
        }
    }
}

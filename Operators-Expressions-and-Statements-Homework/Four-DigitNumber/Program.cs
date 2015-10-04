using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_DigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a=0,b=0,c=0,d=0;
            a = n / 1000;
            b = n / 100 % 10;
            c = n / 10 % 10;
            d = n % 10;
            Console.WriteLine("Sum of digits={0}",a+b+c+d);
            Console.WriteLine("Reversed order: {0}",""+d+c+b+a);
            Console.WriteLine("Last to first: {0}",""+d+a+b+c);
            Console.WriteLine("Switch second and third: {0}",""+a+c+b+d);
        }
    }
}

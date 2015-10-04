 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number between 0 and 500");
            int a = int.Parse(Console.ReadLine());
            while(a<0||a>500)
            {
                Console.WriteLine("Invalid number! Enter again:");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter two float-pointed numbers: ");
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.Write("|{0,-10:X}|",a);
            Console.Write(Convert.ToString(a,2).PadLeft(10,'0'));
            Console.Write("|{0,10:0.00}|",b);
            Console.Write("{0,-10:0.000}|",c);
            Console.WriteLine();
        }
    }
}

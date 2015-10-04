using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long decNum = long.Parse(Console.ReadLine());
            long bit=0;
            string binary="";
            while(decNum>0)
            {
                bit=decNum%2;
                decNum /= 2;
                binary = bit + binary;
            }
            Console.WriteLine(binary);
        }
    }
}

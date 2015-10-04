using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long numDec = long.Parse(Console.ReadLine());
            string hexiDec = "";
            long bit=0;
            while(numDec>0)
            {
                bit = numDec % 16;
                numDec /= 16;
                if(bit<10)
                    hexiDec = bit + hexiDec;
                else
                    switch(bit)
                    {
                        case 10: hexiDec = "A" + hexiDec; break;
                        case 11: hexiDec = "B" + hexiDec; break;
                        case 12: hexiDec = "C" + hexiDec; break;
                        case 13: hexiDec = "D" + hexiDec; break;
                        case 14: hexiDec = "E" + hexiDec; break;
                        case 15: hexiDec = "F" + hexiDec; break;
                    }
            }
            Console.WriteLine(hexiDec);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem8
{
    class Program
    {
        //Problem 8.	Catalan Numbers

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            BigInteger doubleNFactorial = 1;
            BigInteger OnePlusN=1;
            if(n>1 && n<100)
            {
                for (int i = 1; i <= 2*n; i++)
                {
                    doubleNFactorial *= i;
                }
                for (int j = 1; j <=n; j++)
                {
                    OnePlusN *= 1 + j;
                    nFactorial *= j;
                }
            }
            Console.WriteLine(doubleNFactorial/(nFactorial*OnePlusN));
        }
    }
}

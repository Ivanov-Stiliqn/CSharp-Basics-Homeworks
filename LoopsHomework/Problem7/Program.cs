using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem7
{
    class Program
    {
        //Problem 7.	Calculate N! / (K! * (N-K)!)
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger nkFactorial = 1;
            if (k > 1 && k < 100 && k < n && n < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    nFactorial *= i;
                    if(i==k)
                    {
                        kFactorial = nFactorial;
                    }
                }
                for (int j = 1; j <=n-k; j++)
                {
                    nkFactorial *= j;
                }
                Console.WriteLine(nFactorial/(kFactorial*nkFactorial));
            }
            else
                Console.WriteLine("Nekorektni danni");
        }
    }
}

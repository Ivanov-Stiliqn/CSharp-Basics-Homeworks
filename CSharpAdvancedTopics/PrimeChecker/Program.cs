using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static public bool isPrime(double n)
        {
            int flag=0;
            if(n<=2)
                return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        flag = 1;
                }
                if (flag == 0)
                    return true;
                else
                    return false;
            }
        }
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(n));
        }
    }
}

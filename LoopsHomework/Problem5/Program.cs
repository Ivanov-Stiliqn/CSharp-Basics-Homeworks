using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        //Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double S=1;
            int factoriel = 1;
            for (int i = 1; i <=n; i++)
            {
                factoriel *= i;
                S+=factoriel/(Math.Pow(x,i));
            }
            Console.WriteLine("{0:F5}",S);
        }
    }


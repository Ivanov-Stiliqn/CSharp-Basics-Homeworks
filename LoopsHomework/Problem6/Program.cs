using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        //Problem 6.	Calculate N! / K!

        static void Main(string[] args)
        {
            string nString = Console.ReadLine();
            int n;
            int.TryParse(nString, out n);
            string kString = Console.ReadLine();
            int k;
            int.TryParse(kString,out k);
            int nFactoriel = 1;
            int kFactroiel = 1;
            if(k<n&&k>1&&k<100&&n<100)
            {
                for (int i = 1; i <= n; i++)
                {
                    nFactoriel *= i;
                }
                for(int j = 1; j <= k; j++)
                {
                    kFactroiel *= j;
                }
                Console.WriteLine(nFactoriel/kFactroiel);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int swap = 0;
            int[] num = new int[n];
            for (int k = 0; k < n; k++)
            {
                num[k] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (num[i] > num[j])
                    {
                        swap = num[i];
                        num[i] = num[j];
                        num[j] = swap;
                    }
                }
            }
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(num[k]);
            }
        }
    }
}

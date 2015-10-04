using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAreaInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            int maxBr = 0;
            string check = "";
            string result="";
            string[] array = new string[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Console.ReadLine();
            }
            for (int k = 0; k < n - 1; k++)
            {
                check = array[k];
                for (int j = 0; j < n; j++)
                {
                    if (array[j] == check)
                    {
                        br++;
                        if (br > maxBr)
                        {
                            maxBr = br;
                            result = array[j];
                        }
                    }
                    else
                        br = 0;
                }
                if (maxBr == n) break;
            }
            if (maxBr == 0)
                Console.WriteLine("1\n" + array[0]);
            else 
            {
                Console.WriteLine(maxBr);
                for (int i = 0; i < maxBr; i++)
                    Console.WriteLine(result);
            }
        }
    }
}

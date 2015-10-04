using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string[,] array = new string[height, weight];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < weight; j++)
                {
                    Console.Write("" + (char)('a' + i)+(char)('a' +i + j)+(char)('a'+i)+" ");
                }
                Console.WriteLine();
            }
        }
    }
}

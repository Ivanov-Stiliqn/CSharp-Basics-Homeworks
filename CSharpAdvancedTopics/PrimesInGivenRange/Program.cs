using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static List<int> FindPrimeNumbers(int startNum,int endNum)
        {
            List<int> numbers = new List<int>();
            if (startNum < endNum)
            {
                if(startNum<=1)
                {
                    startNum = 2;
                }
                int flag;
                for (int i = startNum; i <= endNum; i++)
                {
                    flag = 0;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                            flag = 1;
                    }
                    if (flag == 0)
                        numbers.Add(i);
                }
            }
                return numbers;
            
        }
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            foreach (var element in FindPrimeNumbers(startNum, endNum))
            {
                Console.Write(element+" ");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTopics
{
    class Program
    {
        static public int Fibunacci(int n)
        {
            int first = 0;
            int second = 1;
            int third = 1;
            for (int i = 0; i < n; i++)
            {
                third = first + second;
                first = second;
                second = third;
            }
            return third;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibunacci(n));
        }
    }
}

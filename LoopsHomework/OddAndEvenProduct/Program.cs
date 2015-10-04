using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenProduct
{
    class Program
    {
        //You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers =input.Split(' ');
            int sumOfOdd=1;
            int sumOfEven=1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                    sumOfEven *= int.Parse(numbers[i]);
                else
                    sumOfOdd *= int.Parse(numbers[i]);
            }
            if(sumOfOdd==sumOfEven)
                Console.WriteLine("yes\nproduct={0}",sumOfEven);
            else
                Console.WriteLine("no\nodd_product={0}\neven_product={1}",sumOfOdd,sumOfEven);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] number =input.Split(' ');
            int first = int.Parse(number[0]);
            int second = int.Parse(number[1]);
            int third = int.Parse(number[2]);
            int fourth = int.Parse(number[3]);
            int fifth = int.Parse(number[4]);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if(int.Parse(number[i])+int.Parse(number[j])==0)
                        Console.WriteLine(number[i]+"+"+number[j]+"=0");
                }
            }
            for (int i = 0; i < 3; i++)
			{

                for (int j= 1; j < 4; j++)
                {

                    for (int k = 2; k < 5; k++)
                    {
                        if (int.Parse(number[i]) + int.Parse(number[j]) + int.Parse(number[k]) == 0)
                            Console.WriteLine(number[i] + "+" + number[j] + "+" + number[k] + "=0");
                    }
                }
            }
        }
     }
 }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] text = input.Split(' ');
            int max=int.MinValue;
            int br = 0;
            string output = "";
            for (int i = 0; i < text.Length; i++)
            {
                br = text[i].Count();
                if (br > max)
                {
                    max = br;
                    output = text[i] + "";
                }
            }
            Console.WriteLine(output);
        }
    }
}

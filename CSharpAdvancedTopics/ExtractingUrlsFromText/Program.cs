using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingUrlsFromText
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] text = input.Split(' ');
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Contains("http://") || text[i].Contains("www."))
                {
                    Console.WriteLine(text[i]);
                }
            }
        }
    }
}

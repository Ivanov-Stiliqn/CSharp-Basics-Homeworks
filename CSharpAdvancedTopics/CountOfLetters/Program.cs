using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] line = input.Split(' ');
            int br = 0;
            List<string> letters = new List<string>();
            List<string> check = new List<string>();
            List<int> number = new List<int>();
            for (int i = 0; i < line.Length; i++)
            {
                letters.Add(line[i]);
            }
            letters.Sort();
            foreach (var element in letters)
            {
                br = 0;
                for (int i = 0; i < letters.Count; i++)
                {
                    if (letters[i] == element)
                    {
                        br++;
                    }
                }
                if (!check.Contains(element))
                {
                    number.Add(br);
                    check.Add(element);
                }
            }
            for (int j = 0; j < check.Count; j++)
            {
                Console.WriteLine("{0} -> {1}",check[j],number[j]);
            }
        }
    }
}

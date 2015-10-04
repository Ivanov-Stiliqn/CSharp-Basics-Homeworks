using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            List<string> firstList = new List<string>();
            List<string> secondList = new List<string>();
            string[] names1 = input1.Split(' ');
            string[] names2 = input2.Split(' ');
            int k=0;
            for (int i = 0; i < names1.Length; i++)
            {
                firstList.Add(names1[i]);
            }
            for (int j = 0; j < names2.Length; j++)
            {
                secondList.Add(names2[j]);
            }
            for (int i = 0; i <secondList.Count; i++)
            {
                for (int j = 0; j < firstList.Count; j++)
                {
                    if (firstList.Contains(secondList[i]));
                        firstList.Remove(secondList[i]);
                }
            }
            foreach(var element in firstList)
                Console.Write(element+" ");
        }
    }
}

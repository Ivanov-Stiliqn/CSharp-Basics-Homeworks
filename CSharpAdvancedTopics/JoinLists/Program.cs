using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string[] firstNum =firstString.Split(' ');
            string[] secondNum = secondString.Split(' ');
            List<int> firstList=new List<int>();
            List<int> secondList=new List<int>();
            for (int i = 0; i < firstNum.Length; i++)
            {
                if (firstList.Contains(int.Parse(firstNum[i])))
                    continue;
                firstList.Add(int.Parse(firstNum[i]));
            }
            for (int j = 0; j < secondNum.Length; j++)
            {
                secondList.Add(int.Parse(secondNum[j]));
            }
            for (int k = 0; k < secondList.Count; k++)
            {
                    if (firstList.Contains(secondList[k]))
                        continue;
                    firstList.Add(secondList[k]);
            }
            firstList.Sort();
            foreach(var element in firstList)
                Console.Write(element+" ");
        }
    }
}

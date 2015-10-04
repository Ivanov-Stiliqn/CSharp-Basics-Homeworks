using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForAPlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(card, out number);
            if((number>1&&number<11)||card=="K"||card=="J"||card=="Q")
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}

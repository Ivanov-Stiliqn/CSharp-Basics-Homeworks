using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int hil=2,des=2,ed=2;
            if (number > 19 && number < 1000)
            {
                hil = number / 100;
                des = number / 10 % 10;
                 ed = number % 10;
            }
            string[] oneToTwenty = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" ,"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
            string[] smallOneToTwenty = { null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "ewelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] lessThanHundred = { null, null,"Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] smLessThanHundred = { null, null,"twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 10)
            {
                Console.WriteLine(oneToTwenty[number]);
            }
            else if (number > 9 && number < 20)
            {
                Console.WriteLine(oneToTwenty[number]);
            }
            else if (number > 19 && number < 100)
            {
                Console.WriteLine(lessThanHundred[des] + " " + smallOneToTwenty[ed]);
            }
            else if ((number > 99 && number < 1000) && (des == 0 || des == 1))
            {
                Console.WriteLine(oneToTwenty[hil] + " hundred " + "and " + smallOneToTwenty[number - hil * 100]);
            }
            else if (number > 99 && number < 1000)
                Console.WriteLine(oneToTwenty[hil] + " hundred and " + smLessThanHundred[des] + " " + smallOneToTwenty[ed]);
        }
    }
}

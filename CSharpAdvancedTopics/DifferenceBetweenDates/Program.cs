using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DifferenceBetweenDates
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan diff;
            CultureInfo bg=new CultureInfo("bg-BG");
            string input1=Console.ReadLine();
            DateTime firstDate;
            string format = "dd.MM.yyyy";
            bool isDate=DateTime.TryParseExact(input1,format,bg,System.Globalization.DateTimeStyles.None,out firstDate);
            string input2=Console.ReadLine();
            DateTime secondDate;
            bool isDate2 = DateTime.TryParseExact(input2, format, bg, System.Globalization.DateTimeStyles.None, out secondDate);
            if(isDate&&isDate2)
            {
                diff = secondDate-firstDate;
                Console.WriteLine(diff.Days);
            }
            else
                Console.WriteLine("Nekorektni danni");
        }
    }
}

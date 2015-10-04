using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace BeerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo enUs = new CultureInfo("en-Us");
            Console.Write("Enter time:");
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");
            DateTime time;
            string currentTime = Console.ReadLine();
            if (DateTime.TryParseExact(currentTime, "h:mm tt", enUs, DateTimeStyles.None, out time))
            {
                if (time >= startTime || time < endTime)
                    Console.WriteLine("beer time");
                else Console.WriteLine("non-beer time");
            }
            else Console.WriteLine("Invalid time");
        }
    }
}

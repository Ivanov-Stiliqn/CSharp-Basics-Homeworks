using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithIntDoubleAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choose = int.Parse(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    {
                        Console.Write("Please enter a integer:");
                        int integer = int.Parse(Console.ReadLine());
                        integer += 1;
                        Console.WriteLine(integer);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Please enter double:");
                        double real = double.Parse(Console.ReadLine());
                        real += 1;
                        Console.WriteLine(real);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Please enter a string:");
                        string str = Console.ReadLine();
                        str = str + '*';
                        Console.WriteLine(str);
                        break;
                    }
            }

        }
    }
}

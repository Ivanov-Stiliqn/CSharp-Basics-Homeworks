using System;
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            byte b = 10;
            byte swap;
            swap = a;
            a = b;
            b = swap;
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= "+b);
        }
    }


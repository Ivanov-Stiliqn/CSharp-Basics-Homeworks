﻿using System;
using System.Text;
    class AsciTable
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.ASCII;
        int column = 0;
        for(byte i=32;i<128;i++)
        {
            if(column==0)
            {
                Console.Write("0x{0:X}", i);
            }
            Console.Write(" {0} ", (char)i);
            if(++column>7)
            {
                column = 0;
                Console.WriteLine();
            }
        }
    }
}

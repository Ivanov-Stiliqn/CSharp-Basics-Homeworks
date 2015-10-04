using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeckOf52Cards
{
    class Program
    {
        //Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

        static void Main(string[] args)
        {
            char pika='\u2660';
            char kupa='\u2665';
            char karo = '\u2666';
            char spatiq = '\u2663';
            string[] deck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i =0; i <deck.Length; i++)
            {
                Console.Write(deck[i]+spatiq+" "+deck[i]+karo+" "+deck[i]+kupa+" "+deck[i]+pika+"\n");
            }
        }
    }
}

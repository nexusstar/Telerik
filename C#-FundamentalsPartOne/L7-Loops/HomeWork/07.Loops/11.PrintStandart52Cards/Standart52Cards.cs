using System;
using System.Collections.Generic;


class Standart52Cards
{
    /// <summary>
    /// ex 11 - Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case
    /// </summary>
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();

        string[] cardsNames = new string[]
        { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] cardsColor = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
        char[] suitSymbol = { '\u2663', '\u2666', '\u2665', '\u2660' };
        
        Console.ForegroundColor = ConsoleColor.Black;

        for (int color = 0; color < cardsColor.Length; color++)
        {
            if (color == 1 || color == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine();
            Console.WriteLine(suitSymbol[color]+ " " + cardsColor[color] );
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            for (int card = 0; card < cardsNames.Length; card++)
            {
                if (color == 1 || color == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine("{0} {1}", suitSymbol[color], cardsNames[card]);
                Console.ForegroundColor = ConsoleColor.Black;
            }   

            
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class FallingRocksGame
{
    /// <summary>
    /// * Implement the "Falling Rocks" game in the text console. 
    /// A small dwarf stays at the bottom of the screen and can move left and right
    /// </summary>

    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    struct Rock
    {
        public int x;
        public int y;
        public string str;
        public ConsoleColor color;
    }

    static void Main()
    {

        // make console buffer height width as window height width
        Console.BufferWidth = Console.WindowWidth = 50;
        Console.BufferHeight = Console.WindowHeight = 30;

        //define myDwarf as Rock object
        Rock myDwarf = new Rock();
        myDwarf.x = 7;
        myDwarf.y = Console.WindowHeight -1;
        myDwarf.str = "(0)";
        myDwarf.color = ConsoleColor.Cyan;
        //Array to contain the characters for the rocks
        char[] rockChar = {'^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };

        //List to contain falling rocks
        List<Rock> rocks = new List<Rock>();

        //Random generator
        Random randomGenerator = new Random();

        //Game field and constants
        int gameFieldWidth = 20;
        int livesCount = 5;

        //rocks
        Rock newRock = new Rock();
        newRock.x = randomGenerator.Next(0, gameFieldWidth + 1);
        newRock.y = 0;
        newRock.str = 
        //The main Game loop
        while (true)
        {
            //create the rocks

            //making sure that key is pressed
            if (Console.KeyAvailable )
            {
                //local var to catch pressed key from console
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                
                //for smooth scrolling this reads all the keys and after that clears it
                while (Console.KeyAvailable) { Console.ReadKey(true); }

                //Move our dwarf
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (myDwarf.x-1 >=0)
                    {
                        myDwarf.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow) 
                {
                    if (myDwarf.x + 1 < gameFieldWidth)
                    {
                        myDwarf.x =myDwarf.x + 1;
                    }
                }
            }
            //Move the Falling Rocks
            //Clear the console
            Console.Clear();
            //Redraw game field
            PrintStringOnPosition(myDwarf.x, myDwarf.y, myDwarf.str, myDwarf.color);
            //draw info
            //slow down program
            Thread.Sleep(600);
            
        }

    }
}
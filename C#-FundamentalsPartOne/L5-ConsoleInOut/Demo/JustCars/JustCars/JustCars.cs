using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

class JustCars
{
    /// <summary>
    /// Just cars game following video from Niki: http://www.youtube.com/watch?v=bQexyufgclY
    /// </summary>

    //method to draw elements on canvas
    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    //---CAR Struct -- could contain different var types as one struct 
    struct Car
    {
        public int x;
        public int y;
        public char c;
        public ConsoleColor color;
    }



    static void Main()
    {
        //Define playfield
        // make console buffer height width as window height width
        Console.BufferWidth = Console.WindowWidth = 30;
        Console.BufferHeight = Console.WindowHeight = 20;
        int playfieldWidth = 15;
        int livesCount = 5;
        double speed = 100.0;
        //user car properties
        Car userCar = new Car();
        userCar.x = 2;
        userCar.y = Console.WindowHeight - 1;
        Console.WriteLine(userCar.y);
        userCar.c = '@';
        userCar.color = ConsoleColor.Yellow;
        Random randomGenerator = new Random();
        List<Car> cars = new List<Car>();

        while (true)
        {
            Car newCar = new Car();
            newCar.color = ConsoleColor.Green;
            newCar.x = randomGenerator.Next(0, playfieldWidth);
            newCar.y = 0;
            newCar.c = '#';
            cars.Add(newCar);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                //for smooth scrolling this reads all the keys and after that clears it
                while (Console.KeyAvailable) { Console.ReadKey(true); }

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userCar.x - 1 >= 0)
                    {
                        userCar.x = userCar.x - 1;
                    }

                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userCar.x + 1 < playfieldWidth)
                    {
                        userCar.x = userCar.x + 1;
                    }
                }

            }

            // Move our car (key pressed)

            // Move Cars
            List<Car> carsUpdate = new List<Car>();
            for (int i = 0; i < cars.Count; i++)
            {
                Car car = cars[i];
                car.y = car.y + 1;

                // Check if other cars are hitting us
                if (car.y == userCar.y && car.x == userCar.x)
                {
                    car.c = 'x';
                    car.color = ConsoleColor.Red;
                    livesCount--;
                    cars.Clear();
                    if (livesCount < 0)
                    {
                        PrintStringOnPosition(8, 7, "Game Over!!", ConsoleColor.Red);
                        PrintStringOnPosition(8, 10, "Press [Enter] to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        return;
                    }

                }
                if (car.y < Console.WindowHeight)
                {
                    carsUpdate.Add(car);
                }

            }
            cars = carsUpdate;

            // Clear the console
            Console.Clear();

            // Redraw playfield
            PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
            foreach (Car car in cars)
            {
                PrintOnPosition(car.x, car.y, car.c, car.color);
            }

            // Draw info
            PrintStringOnPosition(20, 2, "Lives: " + livesCount, ConsoleColor.Red);
            // Slow down program
            Thread.Sleep(600);
        }
    }
}


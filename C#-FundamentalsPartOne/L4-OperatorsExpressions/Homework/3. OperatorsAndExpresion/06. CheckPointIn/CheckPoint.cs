using System;

class CheckPoint
    {
    /// <summary>
    /// ex. 6 Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
    /// A: in order given point (x,y) to be within the circle with (center_x, center_y) and radius
    /// x and y must satisfy (x - center_x)^2 + (y - center_y)^2 less than radius^2
    /// </summary>
        static void Main()
        {
            //get point
            Console.Write("Give point X: ");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("Give point Y: ");
            double pointY = double.Parse(Console.ReadLine());

            double radius = 5;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            //Print result
            
            //short expression but not so readable
            //Console.WriteLine(((pointX*pointX + pointY*pointY) < radius*radius)?"Point is within":"Point is outside or ON ;-)");
            
            //more longer but more easily readable
            double distancePointCenter = pointX * pointX + pointY * pointY;
            if (distancePointCenter < radius * radius)
            {
                Console.WriteLine("Point is within");
            }
            else
            {
                Console.WriteLine("Point is outside or ON ;-)"); //to check if point is on the circle distace^2 == radius^2
            }
        }
    }

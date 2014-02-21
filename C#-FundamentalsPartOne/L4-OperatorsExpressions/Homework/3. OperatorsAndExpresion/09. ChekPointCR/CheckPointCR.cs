using System;

class CheckPointCR
{
    /// <summary>
    /// ex. 9 Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
    /// and out of the rectangle R(top=1, left=-1, width=6, height=2).
    /// </summary>
    static void Main()
    {
        //point
        Console.Write("Enter point X: ");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Enter point Y: ");
        double pointY = double.Parse(Console.ReadLine());
        
        //circle K((1,1), 3)
        double circleX = 1;
        double circleY = 1;
        double circleR = 3;

        //rectangle R(top=1, left=-1, width=6, height=2)
        double rectangleXleft = -1;
        double rectangleYleft = 1;
        double rectangleW = 6;
        double rectangleH = 2;
        double rectangleXright = rectangleXleft + rectangleW;
        double rectangleYright = rectangleYleft - rectangleH;

        //check if point is inside circle
        bool isInsideK = ((pointX - circleX)*(pointX - circleX) + (pointY - circleY)*(pointY-circleY))<=circleR*circleR;
        
        //chek if point is inside rectangle
        bool isPointXin = (pointX >= rectangleXleft && pointX <= rectangleXright); //check if point X is between top left and bottom right corner
        bool isPointYin = (pointY <= rectangleYleft && pointY >= rectangleYright); //check if point Y is betwen top left and bottom right corner
        bool isInsideR = isPointXin && isPointYin ? true : false;
        

        if (isInsideK)
        {
            if (isInsideR)
            {
                Console.WriteLine("The point is within the circle but inside the rectangle");
            }
            else
            {
                Console.WriteLine("The point is within the circle and outside the rectangle");
            }
        }
        else
        {
            if (isInsideR)
            {
                Console.WriteLine("The point is outside the circle but inside the rectangle");
            }
            else
            {
                Console.WriteLine("The point is outside both circle and rectangle");
            }
        }

    }
}

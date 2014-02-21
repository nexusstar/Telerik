namespace _01_Shapes
{
    using System;
    class ShapesTests
    {
        static void Main()
        {
            Circle cir = new Circle(10m);
            
            Shape[] shapes = {
                                 new Triangle(10m,5m),
                                 new Rectangle(5m,5m),
                                 new Circle(10m)
                             };
            foreach (var sh in shapes)
            {
                Console.WriteLine(sh);
            }
            
        }
    }
}

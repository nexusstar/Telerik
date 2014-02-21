namespace Bunny
{
    public struct Point
    {
        public static decimal Calculate(Point first, Point second)
        {
            return 0m;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        //constructor 
        public Point(int x, int y, int z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return "X: " + this.X + " " + "Y: "+ this.Y + " " + "Z: " + this.Z;
        }
    }
}

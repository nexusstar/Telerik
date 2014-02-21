using System.Text;
namespace Points
{
    public struct Point3D
    {
        //fields
        private int x;
        private int y;
        private int z;

        public static readonly Point3D center = new Point3D(0,0,0); //define static field

        //constructor
        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.y = y;
            this.Z = z;
        }

        //Properties
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public int Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        //a readonly static property
        public static Point3D Center
        {
            get
            {
                return center;
            }
        }

        //override ToString method
        public override string ToString()
        {
            StringBuilder pointData = new StringBuilder();

            pointData.Append("X: ").Append(this.x);
            pointData.Append(", Y: ").Append(this.y);
            pointData.Append(", Z: ").Append(this.z);
            pointData.AppendLine();

            return pointData.ToString();

        }
    }
}

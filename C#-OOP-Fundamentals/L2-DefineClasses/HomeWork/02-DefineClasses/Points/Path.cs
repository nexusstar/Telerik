namespace Points
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class Path : System.Collections.CollectionBase
    {
        //field
        private List<Point3D> pointsList;

        //constructors
        public Path()
        {
            this.pointsList = new List<Point3D>();
        }

        public Path(params Point3D[] points)
            : this()
        {
            List<Point3D> list = new List<Point3D>();
            foreach (Point3D point in points)
            {
                list.Add(point);
            }

            this.pointsList = list;
        }


        public List<Point3D> PointsList
        {
            get
            {
                return this.pointsList;
            }
            set
            {
                this.pointsList = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.pointsList.Add(point);
        }

        public void AddPoint(int X, int Y, int Z)
        {
            this.pointsList.Add(new Point3D(X, Y, Z));
        }



        //override ToString()
        public override string ToString()
        {
            StringBuilder pathData = new StringBuilder();

            foreach (Point3D point in this.pointsList)
            {
                pathData.Append(point.X + " " + point.Y + " " + point.Z).AppendLine();
            }
            pathData.AppendLine(); // one extra line after all points to mark end of path

            return pathData.ToString();
        }
    }
}

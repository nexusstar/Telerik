namespace Points
{
    using System;
    using System.Collections.Generic;
    class Test
    {
        static void Main()
        {
            ////Create point
            Point3D point = new Point3D(1, 2, 3);
            Point3D secondPoint = new Point3D(2, 3, 4);

            //print point
            Console.WriteLine(point);
            Console.WriteLine(secondPoint);
            Console.WriteLine(Point3D.center);

            //calculte distance
            double distance = Distance.CalculteDistance(point, secondPoint);
            Console.WriteLine(distance);

            distance = Distance.CalculteDistance(point, Point3D.center);
            Console.WriteLine(distance);

            //Load paths
            List<Path> paths = PathStorage.LoadPaths();
            
            //print loaded paths  
            PrintPaths(paths);

            //Safe path to file
            Point3D firstPathPont = new Point3D(10, 11, 12);
            Point3D secondPathPoint = new Point3D(15, 16, 17);
            Point3D thirdPathPoint = new Point3D(20, 21, 22);

            Path path = new Path(firstPathPont, secondPathPoint, thirdPathPoint);

            PathStorage.SavePath(path);

            List<Path> pathsAfterLoading = PathStorage.LoadPaths();

            //print paths
            PrintPaths(pathsAfterLoading);


        }

        private static void PrintPaths(List<Path> paths)
        {
            Console.WriteLine("There are {0} loaded paths:", paths.Count);
            for (int i = 0; i < paths.Count; i++)
            {
                Console.WriteLine("Path: " + (i + 1));
                Console.Write(paths[i].ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
namespace Points
{
    public static class PathStorage
    {
        private static readonly string filePath = @"../../paths.txt";

        /// <summary>
        /// Load Paths from predefined directory
        /// </summary>
        /// <returns></returns>
        public static List<Path> LoadPaths()
        {
            List<Path> loadedPaths = new List<Path>();
            Path currentPath = new Path();


            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string[] token = reader.ReadLine()
                        .Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    if (token.Length == 3)
                    {
                        int currentX = int.Parse(token[0]);
                        int currentY = int.Parse(token[1]);
                        int currentZ = int.Parse(token[2]);
                        currentPath.AddPoint(currentX, currentY, currentZ);
                    }
                    else
                    {
                        if (currentPath.PointsList.Count > 0)
                        {
                            loadedPaths.Add(currentPath);
                        }
                        currentPath = new Path();
                    }
                }

                //the last path if not added
                if (currentPath.Count != 0)
                {
                    loadedPaths.Add(currentPath);
                }
            }

            return loadedPaths;
        }

        /// <summary>
        /// Add path to file
        /// </summary>
        /// <param name="path">Path to add</param>
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (Point3D point in path.PointsList)
                {
                    writer.WriteLine(point.X + " " + point.Y + " " + point.Z);
                }
                writer.WriteLine(); //empty line for end of path
            }

        }

        public static void SavePath(Path points, string fileFullName)
        {
            if (String.IsNullOrWhiteSpace(fileFullName))
            {
                throw new ArgumentException("File name cannot be null or empty.");
            }

            using (StreamWriter fileWriter = new StreamWriter(fileFullName, false))
            {
                foreach (Point3D point in points)
                {
                    string line = String.Format("{0:F2} {1:F2} {2:F2}", point.X, point.Y, point.Z);
                    fileWriter.WriteLine(line);
                }
            }
        }

    }
}

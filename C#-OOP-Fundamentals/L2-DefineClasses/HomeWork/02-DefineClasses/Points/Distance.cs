namespace Points
{
    using System;
    public static class Distance
    {
        /// <summary>
        /// Calculte distance between two points in 3D space
        /// </summary>
        /// <param name="aPoint">Point in 3D space</param>
        /// <param name="bPoint">Point in 3D space</param>
        /// <returns>Double: distance between two points</returns>
        public static double CalculteDistance(Point3D aPoint, Point3D bPoint)
        {
            double xDistance = (aPoint.X - bPoint.X);
            double yDistance = (aPoint.Y - bPoint.Y);
            double zDistance = (aPoint.Z - bPoint.Z);


            return Math.Sqrt(xDistance * xDistance + yDistance * yDistance + zDistance * zDistance);
        }
    }
}

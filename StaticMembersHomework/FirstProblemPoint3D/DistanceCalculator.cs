using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProblemPoint3D
{
    static class DistanceCalculator
    {
        public static double calculateDistanceBetweenTwoPoints(Point3D point1, Point3D point2)
        {
            int xd = point2.XPoint - point1.XPoint;
            int yd = point2.YPoint - point1.YPoint;
            int zd = point2.ZPoint - point1.ZPoint;

            double distance = Math.Sqrt(xd * xd + yd * yd + zd * zd);

            return distance;
        }
    }
}

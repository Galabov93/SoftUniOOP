using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProblemPoint3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(1, 2, 3);
            Point3D point2 = new Point3D(8, 5, 1);
            Point3D point3 = new Point3D(3, 5, 3);
            Point3D point4 = new Point3D(7, 3, 7);
            Point3D point5 = new Point3D(9, 1, 3);
            Point3D point6 = new Point3D(2, 7, 8);
            Point3D point7 = new Point3D(6, 9, 2);
            Point3D point8 = new Point3D(4, 2, 1);
            Point3D point9 = new Point3D(2, 2, 3);
            Point3D startingPoint = Point3D.StartingPoint;

            double distance = DistanceCalculator.calculateDistanceBetweenTwoPoints(point1, startingPoint);
            Console.WriteLine(distance);

            Point3D[] array = new Point3D[9];
            array[0] = point1;
            array[1] = point2;
            array[2] = point3;
            array[3] = point4;
            array[4] = point5;
            array[5] = point6;
            array[6] = point7;
            array[7] = point8;
            array[8] = point9;
            Path3D path = new Path3D(array);
            Console.WriteLine(path.ToString());




        }
    }
}

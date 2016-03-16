using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProblemPoint3D
{
    class Point3D
    {
        private int x;
        private int y;
        private int z;
        private static readonly Point3D startOfTheCoordinate3D = new Point3D(0, 0, 0);


        public Point3D(int x, int y, int z)
        {
            this.XPoint = x;
            this.YPoint = y;
            this.ZPoint = z;
        }

        public int XPoint
        {
            get
            {
                return this.x;
            }
            set
            {
                bool isNum = int.TryParse(value.ToString(), out value);
                if (isNum)
                {
                    this.x = value;
                }
                else
                {
                    throw new ArgumentException("Enter an integer for the X coordinate");
                }

            }
        }

        public int YPoint
        {
            get
            {
                return this.y;
            }
            set
            {
                bool isNum = int.TryParse(value.ToString(), out value);
                if (isNum)
                {
                    this.y = value;
                }
                else
                {
                    throw new ArgumentException("Enter an integer for the Y coordinate");
                }

            }
        }

        public int ZPoint
        {
            get
            {
                return this.z;
            }
            set
            {
                bool isNum = int.TryParse(value.ToString(), out value);
                if (isNum)
                {
                    this.z = value;
                }
                else
                {
                    throw new ArgumentException("Enter an integer for the Z coordinate");
                }

            }
        }

        public static Point3D StartingPoint
        {
            get
            {
                return startOfTheCoordinate3D;
            }
        }

        public override string ToString()
        {
            return String.Format("p({0},{1},{2})", XPoint, YPoint, ZPoint);
        }
    }
}

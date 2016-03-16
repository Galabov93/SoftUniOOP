using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rhombus : BasicShape
    {
        public Rhombus(double side, double height) : base(side, height)
        {
        }

        public override double calculateArea()
        {
            double area = this.Width * this.Height;
            return area;
        }

        public override double calculatePerimeter()
        {
            double perimeter = this.Height * 4;
            return perimeter;
        }

        public override string ToString()
        {
            return String.Format("A rhombus with side = {0} and height = {1} and :\nArea = {2}    Perimeter = {3}",
                this.Width, this.Height, calculateArea(), calculatePerimeter());
        }
    }
}

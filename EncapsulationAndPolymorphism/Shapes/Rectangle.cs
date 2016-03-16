using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double heigth) : base(width, heigth)
        {
        }

        public override double calculateArea()
        {
            double area = this.Width * this.Height;
            return area;
        }

        public override double calculatePerimeter()
        {
            double perimeter = 2 * this.Height + 2 * this.Width;
            return perimeter;
        }

        public override string ToString()
        {
            return String.Format("A rectangle with width and height = {0}, {1} and:\nArea = {2}    Perimeter = {3}",
                this.Width, this.Height, calculateArea(), calculatePerimeter());
        }
    }
}

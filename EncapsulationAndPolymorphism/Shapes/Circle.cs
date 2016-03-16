using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : BasicShape
    {
        public Circle(double radius) : base(radius)
        {

        }

        public override double calculateArea()
        {
            return Math.PI * this.Width * this.Width; //width = height = radius
        }

        public override double calculatePerimeter()
        {
            return Math.PI * 2 * this.Width;
        }

        public override string ToString()
        {
            return String.Format("A cirle with radius = {0} and:\nArea = {1}    Perimeter = {2}",
                this.Width,calculateArea(),calculatePerimeter());
        }
    }
}

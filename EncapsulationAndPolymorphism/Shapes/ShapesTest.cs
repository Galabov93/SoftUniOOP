using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapesTest
    {
        static void Main(string[] args)
        {
            BasicShape rect1 = new Rectangle(2, 3);
            BasicShape rhombus1 = new Rhombus(22, 4);
            BasicShape rhombus2 = new Rhombus(2.2, 4);
            BasicShape circle1 = new Circle(5.4);
            BasicShape circle2 = new Circle(2);
            IShape rect2 = new Rectangle(2, 3);

            List<BasicShape> listOfShapes = new List<BasicShape>();

            listOfShapes.Add(rect1);
            listOfShapes.Add((BasicShape)rect2);
            listOfShapes.Add(rhombus1);
            listOfShapes.Add(rhombus2);
            listOfShapes.Add(circle1);
            listOfShapes.Add(circle2);

            foreach (var item in listOfShapes)
            {
                Console.WriteLine(item);
            }

        }
    }
}

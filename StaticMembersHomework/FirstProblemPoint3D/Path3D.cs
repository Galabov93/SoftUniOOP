using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProblemPoint3D
{
    class Path3D
    {
        private Point3D[] sequenceOfPoints;

        public Point3D[] Sequence
        {
            get
            {
                return this.sequenceOfPoints;
            }
            set
            {
                this.sequenceOfPoints = value;
            }
        }

        public Path3D(Point3D[] sequence)
        {
            this.Sequence = sequence;
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < Sequence.Length; i++)
            {
                output += String.Format("{0}\n", Sequence[i].ToString());
            }

            return output;
        }

    }
}

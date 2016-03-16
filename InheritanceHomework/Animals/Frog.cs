using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Frog : Animal
    {
        public Frog(string name, uint age) : base(name, age)
        {
        }


        public override void ProduceSound()
        {
            Console.WriteLine("Kvak kvak");
        }
    }
}

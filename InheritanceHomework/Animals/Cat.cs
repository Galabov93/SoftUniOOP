using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, uint age) : base(name, age)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MEOW MEOW");
        }
    }
}

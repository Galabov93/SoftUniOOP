using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, uint age) : base(name, age)
        {
            base.Gender = Gender.FEMALE;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miau miau kitten miau");
        }
    }
}

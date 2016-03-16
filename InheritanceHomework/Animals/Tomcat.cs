using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, uint age, Gender gen) : base(name, age)
        {
            base.Gender = Gender.MALE;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miau miau TomCat miau");
        }
    }
}

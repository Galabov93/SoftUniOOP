using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{

    public enum Gender { MALE, FEMALE };

    public abstract class Animal : ISoundProducable 
    {
        private string name;
        private uint age;
        public Gender Gender;

        public Animal(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name cannot be null");
                }
                this.name = value;
            }
        }

        public uint Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return String.Format("{0}   {1} years old",this.name,this.age);
        }
    }
}

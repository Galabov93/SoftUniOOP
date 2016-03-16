using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            { return this.firstName; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("The first name cannot be null");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The last name cannot be null");
                }

                this.lastName = value;
            }
        }

    }
}

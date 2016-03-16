using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public abstract class Person
    {
        private string id;
        private string firstName;
        private string lastName;

        public Person(string id , string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("The persons id cannot be null");
                }

                if(value.Length != 10)
                {
                    throw new ArgumentException("The persons id should consist 10 digits");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The persons firs name cannot be null");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The persons last name cannot be null");
                }

               this.lastName = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} id: {2}",this.firstName,this.lastName,this.Id);
        }
    }
}

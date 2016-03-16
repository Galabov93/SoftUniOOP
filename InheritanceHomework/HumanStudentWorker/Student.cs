using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length > 5 && value.Length <= 10)
                {
                    char[] array = value.ToCharArray();

                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(array[i]))
                        {
                            throw new ArgumentException
                                ("The faculty number should consist only numbers and letters");
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("The faculty number length shoud be in the range [5-10]");
                }

                this.facultyNumber = value;

            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}, FN:  {2}", this.FirstName, this.LastName, this.facultyNumber);
        }


    }
}

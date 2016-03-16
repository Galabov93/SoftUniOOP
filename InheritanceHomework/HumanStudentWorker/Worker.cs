using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;


        public Worker(string firstName, string lastName, double weekSalary, int workHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHours;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The salary cannot be a negative number");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The week hours cannot be a negative number");
                }

                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            return this.weekSalary / this.workHoursPerDay;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}; Work hours per day: {2} ;  SalaryPerHour: {3:F2} ",
                this.FirstName, this.LastName, this.WorkHoursPerDay, MoneyPerHour());
        }
    }
}

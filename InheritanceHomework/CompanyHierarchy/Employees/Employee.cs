using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Employees
{
    public enum Department { Production, Accounting, Sales, Marketing };

    public abstract class Employee : Person
    {
        private double salary;
        public Department Department { get; set; }


        public Employee(string id, string firstName, string lastName, Department department)
            : base(id, firstName, lastName)
        {
            this.Department = department;
        }





    }
}

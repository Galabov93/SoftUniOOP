using CompanyHierarchy.Employees;
using System;
using System.Collections.Generic;

namespace CompanyHierarchy
{
    public class Manager : Employee
    {
        private readonly List<Employee> listOfEmployees = new List<Employee>();

        public Manager(string id, string firstName, string lastName, Department department, List<Employee> listOfEmployees)
            : base(id, firstName, lastName, department)
        {
        }

        public List<Employee> ListOfEmployees
        {
            get
            {
                return this.listOfEmployees;
            }
        }
    }
}

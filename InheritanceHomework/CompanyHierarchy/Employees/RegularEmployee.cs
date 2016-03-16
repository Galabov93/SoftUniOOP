using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Employees
{
    public class RegularEmployee : Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, Department depart)
            : base(id, firstName, lastName, depart)
        {
        }

      
    }
}
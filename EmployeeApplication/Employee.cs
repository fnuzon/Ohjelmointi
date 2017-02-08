using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Employee
    {
        public string name { get; set; }
        public string profession { get; set; }
        public int salary { get; set; }
        
        public Employee()
        {

        }

        public Employee(string Name, string Prof, int Salary)
        {
            name = Name;
            profession = Prof;
            salary = Salary;
        }
    }
}

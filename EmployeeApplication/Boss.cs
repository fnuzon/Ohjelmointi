using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Boss : Employee
    {
        public string car { get; set; }
        public int bonus { get; set; }

        public Boss()
        {

        }

        public Boss(string Name, string Prof, int Salary, string Car, int Bonus)
            : base(Name, Prof, Salary)
        {
            name = Name;
            profession = Prof;
            salary = Salary;
            car = Car;
            bonus = Bonus;
        }
    }
}

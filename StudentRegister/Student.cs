using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegister
{
    class Student
    {
        public string Name { get; set; }
        public string School { get; set; }
        public int Age { get; set; }
        public string Studies { get; set; }
        public string Nat { get; set; }
        
        public Student(string name, string school, int age, string studies, string nat)
        {
            Name = name;
            School = school;
            Age = age;
            Studies = studies;
            Nat = nat;
        }                       
    }
}
